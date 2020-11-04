using System.Runtime.CompilerServices;
using UnityEngine;
public class Score : MonoBehaviour
{
    public float scoreValue = 0f;
    private static Score scoreInstance = null;

    private void Awake()
    {
        if (this != Instance)
        {
         Destroy(this);
        }


        if (this == scoreInstance)
        {
            DontDestroyOnLoad(this);
        }

        //SetScore();
    }

    public static Score Instance
    {
        get
        {
            if (scoreInstance == null)
               scoreInstance = FindObjectOfType<Score>();
            return scoreInstance;
        }
    }

    //public void SetScore ()
    //{
     
            
    //}
}

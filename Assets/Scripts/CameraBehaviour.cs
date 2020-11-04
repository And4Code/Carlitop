using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public BackgroundMove backgroundMid;
    public BackgroundMove backgroundBottom;
    public BackgroundMove backgroundTop;

    

    
    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-0.5f, 0.5f) * magnitude;
            float y = Random.Range(-0.5f, 0.5f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;
            
            yield return null;
        }
        
        transform.localPosition = originalPos;
    }
    public IEnumerator AccelerationBackground(float duration)
    {
        float originalSpeed = backgroundBottom.speed;
        
        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            backgroundMid.speed = -10;
            backgroundBottom.speed = -10;
            backgroundTop.speed = -10;

            elapsed += Time.deltaTime;

            yield return null;
            
        }
        backgroundBottom.speed = originalSpeed;
        backgroundMid.speed = originalSpeed;
        backgroundTop.speed = originalSpeed;


    }
}

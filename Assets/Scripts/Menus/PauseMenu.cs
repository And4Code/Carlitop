using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

	[SerializeField]
	private Texture2D m_Resume;
	[SerializeField]
	private Texture2D m_Quit;
	[SerializeField]
	private Texture2D m_Pause;



	private bool isPaused = false;


	void Start()
	{

	}


	void Update()
	{
		
		if (Input.GetKeyDown(KeyCode.Escape))
			isPaused = !isPaused;


		if (isPaused)
			Time.timeScale = 0f;

		else
			Time.timeScale = 1.0f; 


	}

	void OnGUI()
	{
		if (isPaused)
		{

			GUI.DrawTexture(new Rect(Screen.width / 2 - 110, Screen.height / 2 - 120, 240, 300), m_Pause);

			if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 , 80, 40), m_Resume))
			{
				isPaused = false;
			}

			if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 + 60, 80, 40), m_Quit))
			{
				// Application.Quit(); 
				Application.LoadLevel("MainMenu"); 

			}

		    

		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject PauseMenuUI;
    private bool isPaused;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.J))
        {
            Cursor.visible = !Cursor.visible;
            Cursor.lockState = (Cursor.lockState == CursorLockMode.Locked) ? CursorLockMode.None : CursorLockMode.Locked;
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DesactivateMenu();

        }
    }

    public void ActivateMenu()
    {
        Time.timeScale = 0;
        PauseMenuUI.SetActive(true);

    }

    public void DesactivateMenu()
    {
        Time.timeScale = 1;
        PauseMenuUI.SetActive(false);
        isPaused = false;

    }
    public void QuitGame()

    {
        Debug.Log("QUIT");
        Application.Quit();
    }

}

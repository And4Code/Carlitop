﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaComponent : MonoBehaviour
{
    public float maxStamina = 100f;
    public float currentStamina;
    public StaminaBar staminaBar;
    public GameManager gameManager;
    public CameraBehaviour cameraBehaviour;
    
    
    

    void Start()
    {
        currentStamina = 95f;
        
    }

    private void Update()
    {
        currentStamina += 0.01f * Time.deltaTime;

        
            if (currentStamina >= maxStamina)
            {
                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    gameManager.Disable();
                    StartCoroutine(UseStamina(8));
                    cameraBehaviour.StartCoroutine(cameraBehaviour.Shake(8, 0.4f));
                    cameraBehaviour.StartCoroutine(cameraBehaviour.AccelerationBackground(8));
                    gameManager.Multiply();
                }


            }
        

        
       

        staminaBar.SetStamina(currentStamina);
    }

    public void IncreaseStamina(float value)
    {
        currentStamina += value;
        staminaBar.SetStamina(currentStamina);
    }

    public IEnumerator UseStamina(float duration)
    {
        float elapsed = 0.0f;
        while(elapsed < duration)
        {
            currentStamina -= 12.5f * Time.deltaTime;
            elapsed += Time.deltaTime;
            yield return null;
        }

        gameManager.Enable();
        
    }
    
    
        
        
        
    
}

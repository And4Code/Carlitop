using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaComponent : MonoBehaviour
{
    public float maxStamina = 100f;
    public float currentStamina;
    public StaminaBar staminaBar;

    void Start()
    {
        currentStamina = 80f;
    }

    private void Update()
    {
        currentStamina += 0.01f * Time.deltaTime;
        if (currentStamina >= maxStamina && Input.GetKeyDown(KeyCode.LeftShift))
        {

        }
        staminaBar.SetStamina(currentStamina);
    }

    public void IncreaseStamina(float value)
    {
        currentStamina += value;
        staminaBar.SetStamina(currentStamina);
    }
}

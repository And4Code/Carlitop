using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaComponent : MonoBehaviour
{
    public float maxStamina = 100f;
    public float currentStamina;

    void Start()
    {
        currentStamina = 0f;
    }

    private void Update()
    {
        currentStamina += 0.01f * Time.deltaTime;
        if (currentStamina >= maxStamina && Input.GetKeyDown(KeyCode.LeftShift))
        {

        }
    }

    public void IncreaseStamina(float value)
    {
        currentStamina += value;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider slider;
    public StaminaComponent staminaComponent;
    void Start()
    {
        slider.value = staminaComponent.currentStamina;
    }

    public void SetStamina(float stamina)
    {
        slider.value = staminaComponent.currentStamina;
    }
}

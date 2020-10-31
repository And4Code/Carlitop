using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public PHealthComponent healthComponent;

    public void Start()
    {
        slider.value = healthComponent.currentHealth;
    }


    public void SetHealth(int health)
    {
        slider.value = healthComponent.currentHealth;


    }

}

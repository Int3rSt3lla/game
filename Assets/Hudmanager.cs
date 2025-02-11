using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Hudmanager : MonoBehaviour
{
    public Slider healthSlider;

    public void UpdateHealthBar(int value)
    {
        healthSlider.value = value;
    }

    public void SetMaxValue(int maxValue)
    {
        healthSlider.maxValue = maxValue;
    }
}

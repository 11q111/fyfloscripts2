using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;
    public float maxHealth = 100;
    public float health;
    public int coins;
    
    void Update()
    {
        healthSlider.maxValue = maxHealth;
        healthSlider.value = healthSlider.maxValue;

        coinsCounterText.text = coins.ToString();
    }
}
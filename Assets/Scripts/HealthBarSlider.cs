using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : MonoBehaviour
{
    public Stats statsScript;
    public Image fillImage;
    private Slider slider;

    public float playerHealth;
    

    private void Awake()
    {
        slider = GetComponent<Slider>();

        playerHealth = statsScript.currentHealth;
       
    }

    private void Update()
    {
        Health();
    }

    public void Health()
    {
        float fillvalue = statsScript.currentHealth / statsScript.maxHealth;
        slider.value = fillvalue;
    }
}

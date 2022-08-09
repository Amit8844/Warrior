using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Stats : CoreComponent
{
    public float currentHealth;
    public float maxHealth;

    [SerializeField] private GameObject GameObject;
    [SerializeField] private GameObject bloodParticles;
    [SerializeField] private GameObject deathChunkParticles;


    protected override void Awake()
    {
        base.Awake();
       
        currentHealth = maxHealth;
    }
     public void DecreaseHealth(float amount)
    {
        currentHealth -= amount;
       
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            bloodParticles = Instantiate(bloodParticles,transform.position, Quaternion.identity);
            deathChunkParticles = Instantiate(deathChunkParticles,transform.position, Quaternion.identity);
            GameObject.SetActive(false);
        }
    }

}

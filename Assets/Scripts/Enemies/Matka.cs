using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matka : MonoBehaviour, IDamageable
{
    [SerializeField] private GameObject hitParticles;
    [SerializeField] private GameObject bloodObjects;
    [SerializeField] private GameObject powerUp;

    
     private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Damage(float amount)
    {
        Debug.Log(amount + " Damage taken");

        Instantiate(hitParticles, transform.position, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
        anim.SetTrigger("damage");
        Destroy(gameObject);
        GameObject.Instantiate(bloodObjects, transform.position, bloodObjects.transform.rotation);
        GameObject.Instantiate(powerUp, transform.position,powerUp.transform.rotation);
    }


}

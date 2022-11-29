using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour,IDamageable
{
    [SerializeField] private GameObject hitParticles;
    [SerializeField] private GameObject bloodObjects;
    [SerializeField] private GameObject Gems;

    private float amount = 50f;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Damage(float amount)
    {
        Debug.Log(amount + " Damage taken");
        if (amount == 10)
        {
            Instantiate(hitParticles, transform.position, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
            anim.Play("Chest_Open");
        }
        else
        {
            if(amount > 10)
            {
                Instantiate(hitParticles, transform.position, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
                //anim.SetTrigger("damage");
                Destroy(gameObject);
                GameObject.Instantiate(bloodObjects, transform.position, bloodObjects.transform.rotation);
                GameObject.Instantiate(Gems, transform.position, Gems.transform.rotation);
            }

        }

    }
}

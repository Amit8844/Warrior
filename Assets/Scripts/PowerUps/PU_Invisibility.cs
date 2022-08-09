using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PU_Invisibility : MonoBehaviour
{
    private SpriteRenderer sr;
    private Color col;
    private float activationTime ;
    
    private bool invisible;

    public GameObject comb;
    public GameObject pl;
   
    

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
       
        activationTime = 0f;
        invisible = false;
        col = sr.color;
      
     }

    private void Update()
    {
        activationTime += Time.deltaTime;

        if (invisible && activationTime >= 3)
        {
            invisible = false;
            col.a = 1;
            sr.color = col;
            comb.layer = LayerMask.NameToLayer("Player");
            pl.layer = LayerMask.NameToLayer("Player");
        }
    }

     private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Invisible"))
        {
            invisible = true;
            activationTime = 0f;
            col.a = .3f;
            sr.color = col;
            comb.layer = LayerMask.NameToLayer("Damageable");
            pl.layer = LayerMask.NameToLayer("Damageable");
            Destroy(other.gameObject);
        }
    }
}

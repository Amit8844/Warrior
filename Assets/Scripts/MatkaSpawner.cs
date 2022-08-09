using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatkaSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Matka;
    

    private void Start()
    {
       Matka = Instantiate(Matka, transform.position, Quaternion.identity);
    }
}

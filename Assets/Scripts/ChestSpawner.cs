using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Chest;


    private void Start()
    {
        Chest = Instantiate(Chest, transform.position, Quaternion.identity);
    }
}

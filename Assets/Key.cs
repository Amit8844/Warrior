using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
   
    public static int ScoreNum = 0;
    public GameObject door;


    private void Start()
    {
        door.SetActive(false);
    }

    private void Update()
    {
        NextLevel();
    }

    void OnTriggerEnter2D(Collider2D KEY)
    {
         
        if (KEY.CompareTag("Player"))
        {

            ScoreNum++;
           // Debug.Log("collected"+Key.ScoreNum);
            Destroy(gameObject);
            Debug.Log(ScoreNum);
        }

    }   

    public void NextLevel()
    {

        if(ScoreNum >= 3)
        {
            Debug.Log("Opened");
            door.SetActive(true); 
        }
    }

}

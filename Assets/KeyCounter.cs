using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCounter : MonoBehaviour
{
    private Text MyscoreText;


    private void Start()
    {
        MyscoreText = GetComponent<Text>();  
    }

    private void Update()
    {
        if (MyscoreText.text != Key.ScoreNum.ToString())
        {
            MyscoreText.text = Key.ScoreNum.ToString();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    int score;
    TMP_Text scoretext;
    
    void Start() 
    {
      scoretext = GetComponent<TMP_Text>();  
      scoretext.text = "00";
    }

    public void Scoring (int increaseAmount)
    {
    
     score += increaseAmount;
     
     scoretext.text = score.ToString();
    }
}

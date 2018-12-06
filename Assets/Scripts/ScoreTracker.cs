using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //<- "namespace"

public class ScoreTracker : MonoBehaviour

{ //skapar en public variabel till "TextMeshProGUI" som heter scoreText
    public TextMeshProUGUI scoreText;
    //skapar en public variabel som är en int och heter totalScore
    public int totalScore;

    //en privat void som kollar efter uppateringar
    private void Update()
    {
        //gör att scoreText skriver "Score (totalScore)" av 10
        scoreText.text = string.Format("Score: {0}/10", totalScore);
    }
}

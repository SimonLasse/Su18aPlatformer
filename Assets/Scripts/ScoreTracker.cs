using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using TMPro; //<- "namespace"

public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreText; //skapar en public variabel till "TextMeshProGUI" som heter scoreText
    public int totalScore; //skapar en public variabel som är en int och heter totalScore

    private void Update()
    {
        scoreText.text = string.Format("Score: {0}", totalScore); //gör att scoreText skriver "Score (totalScore)"
    }
}

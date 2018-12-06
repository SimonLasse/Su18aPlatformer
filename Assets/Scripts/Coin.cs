using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //skapar och sätter en public int med variabeln "score" till 1
    public int score = 1;

    //gör att när trigger går på gör den
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") //ifall det som colliderade har tagen player
        {
            //Skapa en temporär variabel "controller" och sätt den till
            //resultatet av sökningen efter objektet med taggen "GameController".
            GameObject Player = GameObject.FindWithTag("GameController");
            if (Player != null)
            {
                //Skapa en temporär variabel "tracker" och sätt den till
                //resultatet av sökningen efter komponenten "ScoreTracker".
                ScoreTracker tracker = Player.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    //den letar upp "totalscore" och lägger på en
                    tracker.totalScore += score;
                }
                //om inte
                else
                {
                    //om den inte hittar printar den "ScoreTracker saknas på GameController."
                    Debug.LogError("ScoreTracker saknas på GameController.");
                }
            }
            //om inte
            else
            {
                // om den inte hittar gamecontroller printar den "GameContoller finns inte."
                Debug.LogError("GameContoller finns inte.");
            }
            //gör sönder ett objekt
            Destroy(gameObject);
        }
    }
}

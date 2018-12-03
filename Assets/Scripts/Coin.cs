using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score = 1; //sätter score till 1

    private void OnTriggerEnter2D(Collider2D collision) //gör att när trigger går på gör den
    {
        if (collision.tag == "Player") //ifall det som colliderade har tagen player
        {
            //Skapa en temporär variabel "controller" och sätt den till
            //resultatet av sökningen efter objektet med taggen "GameController".
            GameObject Player= GameObject.FindWithTag("GameController");
            if (Player != null)
            {
                //Skapa en temporär variabel "tracker" och sätt den till
                //resultatet av sökningen efter komponenten "ScoreTracker".
                ScoreTracker tracker = Player.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    tracker.totalScore += score; //den letar upp "totalscore" och lägger på en
                }
                else
                {
                    Debug.LogError("ScoreTracker saknas på GameController.");//om den inte hittar printar den "ScoreTracker saknas på GameController."
                }
            }
            else
            {
                Debug.LogError("GameContoller finns inte.");// om den inte hittar gamecontroller printar den "GameContoller finns inte."
            }

            Destroy(gameObject); //gör sönder ett objekt
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBoost : MonoBehaviour
{




    //om ngt kolliderar med den går den in hit
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //har objektet som kolliderade taggen "Player"
        if (collision.gameObject.tag == "Player") ;
        {
            //Skapa en temporär variabel "controller" som ska leta efter komponenten "PlayerHealth"
            //ifall controllern inte är noll(ifall den hittar ngt)
            GameObject controller = GameObject.FindWithTag("Player");
            if (controller != null)
            {
                //Skapa en temporär variabel "tracker" som ska leta efter komponenten "PlayerHealth"
                //ifall trackern inte är noll(ifall den hittar ngt)
                PlayerHealth tracker = controller.GetComponent<PlayerHealth>();
                if (tracker != null)
                {
                    //gör negativt 25 "DealDamage"
                    tracker.DealDamage(-25);

                }
                //om inte
                else
                {
                    //printa "oh no"
                    Debug.LogError("oh no");
                }
            }
            //om inte
            else
            {
                //printa "oh no"
                Debug.LogError("oh no");
            }
            //förstör spel objektet
            Destroy(gameObject);
        }

    }
}

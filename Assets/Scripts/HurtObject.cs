using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//lägger till så att skriptet har tillgång att hantera scenerna
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{
    //när den kolliderar med ngt går den in här
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //ifall objektet den kolliderar med har taggen "player"
        if (collision.gameObject.tag == "Player")
        {
            //Skapar en variabel som heter active och gör att den betyder "GetActiveScene" alltså hämta den scenen som är aktiv för tillfället
            Scene active = SceneManager.GetActiveScene();
            //laddar den activa scenen 
            SceneManager.LoadScene(active.name);
        }
    }
}

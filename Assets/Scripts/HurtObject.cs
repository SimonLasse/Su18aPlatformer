using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //lägger till så att skriptet har tillgång att hantera scenerna

public class HurtObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) //när den kolliderar med ngt går den in här
    {
        if(collision.gameObject.tag == "Player") //ifall objektet den kolliderar med har taggen "player"
        {
            Scene active = SceneManager.GetActiveScene(); //Skapar en variabel som heter active och gör att den betyder "GetActiveScene" alltså hämta den scenen som är aktiv för tillfället
            SceneManager.LoadScene(active.name);//laddar den activa scenen  
        }
    }
}

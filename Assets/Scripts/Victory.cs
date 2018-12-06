using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// gör så att detta skriptet kan hantera scenerna
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    //gör en variabel som är en string och säger att "levelToLoad = SampleScene"
    public string levelToLoad = "SampleScene";

    //när triggern går på gör den detta
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ifall objektet som slog på triggern har taggen "Player"
        if (collision.tag == "Player")
        {
            //skriv ut "Yay"
            print("Yay");
            //laddar scenen "levelToLoad" vilket e satt som "SampleScene" men som kan ändras i unity
            SceneManager.LoadScene(levelToLoad);
        }
    }
}

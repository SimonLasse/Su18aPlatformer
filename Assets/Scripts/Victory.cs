using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// gör så att detta skriptet kan hantera scenerna

public class Victory : MonoBehaviour
{
    public string levelToLoad = "SampleScene";//gör en variabel som är en string och säger att "levelToLoad = SampleScene"

    private void OnTriggerEnter2D(Collider2D collision) //när triggern går på gör den detta
    {
        if(collision.tag == "Player") //ifall objektet som slog på triggern har taggen "Player"
        {
            print("Yay"); //skriv ut "Yay"
            SceneManager.LoadScene(levelToLoad);//laddar scenen "levelToLoad" vilket skrevs tidigare var "SampleScene"
        }
    }
}

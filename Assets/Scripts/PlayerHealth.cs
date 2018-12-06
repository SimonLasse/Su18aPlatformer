using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//gör så att skriptet får tillgång till lite mer UI grejer i unity
using UnityEngine.UI;
//gör att skriptet kan hantera scener
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    //skapar en public float som heter MaxHealth med värde 100
    public float MaxHealth = 100f;
    //skapar en public float som heter currentHealth 
    public float currentHealth;
    //skapar en public Slider som heter healthbar
    public Slider healthbar;



    // Use this for initialization
    private void Start()
    {
        //sätter currentHealth till MaxHealth
        currentHealth = MaxHealth;
        //sätter healthbar.value till CalculateHealth
        healthbar.value = CalculateHealth();

    }
    //skapar en DealDamage void
    public void DealDamage(float damageValue)
    {
        //säger att currentHealth är lika med currentHealth - damageValue
        currentHealth -= damageValue;
        //säger att healthbar.value är lika med CalculateHealth
        healthbar.value = CalculateHealth();


    }
    //när ngt kolliderar går den in här
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //ifall det som kolliderar har taggen "TinyEnemy"
        if (collision.gameObject.tag == "TinyEnemy")
        {
            //gör DealDamage värde 25
            DealDamage(25f);
        }
        //iffal kollitions objektet har taggen "BigEnemy"
        if (collision.gameObject.tag == "BigEnemy")
        {
            //gör DealDamage värde 75
            DealDamage(75f);
        }
    }
    //skapar en CalculateHealth float
    float CalculateHealth()
    {
        //som skriver ut currentHealth / MaxHealth
        return currentHealth / MaxHealth;
    }
    // Update is called once per frame
    void Update()
    {
        //ifall currentHealth är lika med eller mindre än 0
        if (currentHealth <= 0f)
        {
            //Skapar en variabel som heter active och gör att den betyder "GetActiveScene" alltså hämta den scenen som är aktiv för tillfället
            Scene active = SceneManager.GetActiveScene();
            //laddar den activa scenen 
            SceneManager.LoadScene(active.name);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public float MaxHealth = 100f;
    public float currentHealth;
    public Slider healthbar;
    


    // Use this for initialization
    private void Start()
    {
        currentHealth = MaxHealth;
        healthbar.value = CalculateHealth();

    }

    public void DealDamage(float damageValue)
    {
        //if (currentHealth => 100f)
        {
        currentHealth -= damageValue;
        healthbar.value = CalculateHealth();

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "TinyEnemy")
        {
            DealDamage(50f);
        }
    }
    float CalculateHealth()
    {
        return currentHealth / MaxHealth;
    }
    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0f)
        {
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
        }
    }
}

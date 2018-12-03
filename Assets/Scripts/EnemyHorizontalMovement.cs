using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float moveSpeed = 2f; //skapar en float som går att redigera i unity med namnet moveSpeed
    public bool isLeft = true; //skapar en bool som går att redigera i unity med namnet isLeft och sätter den till true
    private Rigidbody2D rbody; //en privat variabel som heter rbody
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>(); //rbody hämtar komponenten "Rigidbody2D"
        Move(false);// variabeln Move är falsk
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))//ifall H blir nedtryckt gör den detta
        {
            Move(true); //sätt Move till true
        }
    }

    void Move(bool flip)
    {
        if (flip == true) //ifall flip är true
        {
            isLeft = !isLeft; // den ska flippa till riktingen tvärtom från isLeft altså till höger
        }

        if (isLeft == true) //ifall isLeft är true
        {
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y); //säger att ta den hastighet på variabeln "moveSpeed" och göra den negativ så den går åt vänster
            transform.localScale = new Vector3(1, 1, 1); //Gör att den flippar spriten så den kollar åt höger
        }
        else //om inte
        {
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y); //säger att ta den hastighetern på variabeln "moveSpeed" (som redan är positiv och gör att den går till höger)
            transform.localScale = new Vector3(-1, 1, 1); //gör att den flippar spriten till vänster
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) //om den nuddar ett objekt som är en trigger går den hit
    {
        if(collision.tag == "InvisibleWall") //ifall den kolliderar med ett objekt (som är en trigger) med taggen "InvisibleWall" gör den detta 
        {
            Move(true); // sätter "Move" till true
        }
    }
}

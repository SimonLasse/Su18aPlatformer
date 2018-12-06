using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    //skapar en float som går att redigera i unity med namnet moveSpeed
    public float moveSpeed = 2f;
    //skapar en bool som går att redigera i unity med namnet isLeft och sätter den till true
    public bool isLeft = true;
    //en privat variabel som heter rbody
    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        //rbody hämtar komponenten "Rigidbody2D"
        rbody = GetComponent<Rigidbody2D>();
        // variabeln Move är falsk
        Move(false);
    }

    // Update is called once per frame
    void Update()
    {
        //ifall H blir nedtryckt gör den detta
        if (Input.GetKeyDown(KeyCode.H))
        {
            //sätt Move till true
            Move(true);
        }
    }
    //skapar en void till Move så när void Upate checkar går den hit
    void Move(bool flip)
    {
        //ifall flip är true
        if (flip == true)
        {
            // den ska flippa till riktingen tvärtom från isLeft altså till höger
            isLeft = !isLeft;
        }

        //ifall isLeft är true
        if (isLeft == true)

        {
            //säger att ta den hastighet på variabeln "moveSpeed" och göra den negativ så den går åt vänster
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            //Gör att den flippar spriten så den kollar åt höger
            transform.localScale = new Vector3(1, 1, 1);
        }
        //om inte
        else
        {
            //säger att ta den hastighetern på variabeln "moveSpeed" (som redan är positiv och gör att den går till höger)
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            //gör att den flippar spriten till vänster
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    //om den nuddar ett objekt som är en trigger går den hit
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ifall den kolliderar med ett objekt (som är en trigger) med taggen "InvisibleWall" gör den detta 
        if (collision.tag == "InvisibleWall")
        {
            // sätter "Move" till true
            Move(true);
        }
    }
}

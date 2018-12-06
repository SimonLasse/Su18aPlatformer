using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//du måste ha en rigidbody på objektet för att skriptet ska funka
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //skapar en slider till moveSpeed variabeln med ett lägsta värde på 0 och högsta på 20
    [Range(0, 20f)]
    //skapar en public float variabel som heter moveSpeed
    public float moveSpeed;
    //skapar en public float variabel som heter jumpHeight
    public float jumpHeight;

    //skapar en private Rigidbody2D variabel som heter rbody
    private Rigidbody2D rbody;
    //skapar en public GroundCheck variabel som heter groundCheck
    public GroundCheck groundCheck;

    // Use this for initialization
    void Start()
    {
        //variabeln rbody hämtar komponenten "Rigidbody2D"
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //gör att knapparna A, D och L arrow, R arrow kan styra objektet horisontellt, och´att hastigheten är vad som är satt på moveSpeed variabeln
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);

        // ifall man trycker ner Space händer detta
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //ifall touches i groundCheck är över ett
            if (groundCheck.touches > 0)
            {
                //att du hoppar med längden satt på variabeln jumpHeight
                rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
            }
        }
    }
}

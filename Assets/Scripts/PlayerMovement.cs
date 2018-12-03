using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] //du måste ha en rigidbody på objektet för att skriptet ska funka
public class PlayerMovement : MonoBehaviour
{
    [Range(0, 20f)] //skapar en slider till moveSpeed variabeln med ett lägsta värde på 0 och högsta på 20
    public float moveSpeed;//skapar en public float variabel som heter moveSpeed
    public float jumpHeight;//skapar en public float variabel som heter jumpHeight

    private Rigidbody2D rbody;//skapar en private Rigidbody2D variabel som heter rbody
    public GroundCheck groundCheck;//skapar en public GroundCheck variabel som heter groundCheck

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>(); //variabeln rbody hämtar komponenten "Rigidbody2D"
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal") * moveSpeed,
            rbody.velocity.y);//gör att knapparna A, D och L arrow, R arrow kan styra objektet horisontellt, och´att hastigheten är vad som är satt på moveSpeed variabeln

        if (Input.GetKeyDown(KeyCode.Space)) // ifall man trycker ner Space händer detta
        {
            if (groundCheck.touches > 0) //ifall touches i groundCheck är över ett
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight); //att du hoppar med längden satt på variabeln jumpHeight
            }
        }
    }
}

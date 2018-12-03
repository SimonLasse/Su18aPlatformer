using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public int touches; //skapar en public int med variabeln touches

    private void OnTriggerEnter2D(Collider2D collision) //när den nuddar en  trigger gör den
    {
        touches++; //lägg plus en från touches
    }

    private void OnTriggerExit2D(Collider2D collision) //när den slutar nudda en trigger
    {
        touches--; //ta bort en från touches
    }
}

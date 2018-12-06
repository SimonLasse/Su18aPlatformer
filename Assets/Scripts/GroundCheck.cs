using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    //skapar en public int med variabeln touches
    public int touches;

    //när den nuddar en  trigger gör den
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //lägg plus en på touches
        touches++;
    }

    //när den slutar nudda en trigger
    private void OnTriggerExit2D(Collider2D collision)
    {
        //ta bort en på touches
        touches--;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvisible : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        //stänger av SpriteRenderern
        GetComponent<SpriteRenderer>().enabled = false;
    }
}

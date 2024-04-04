using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : playerControler
{
    protected override void Update()
    {
        speed = 200f; //change speed
        base.Update();
    }
}

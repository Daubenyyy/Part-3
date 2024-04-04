using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player1 : playerControler
{
    //varibles
    Coroutine jump;
    float timer = 0;
    float maxTimer = 300;
    protected override void Jump()//overrides jump
    {
        if(jump!= null)
        {
            StopCoroutine(jump);
            timer = 0;
        }
        jump = StartCoroutine(Jumping());
    }

    IEnumerator Jumping()
    {
        Vector2 jumpForce = new Vector2(0, 200);
        base.Jump();
        while (timer < maxTimer) //makes character flip while jumping
        {
            transform.Rotate(0, 0, 1);
            timer++;
            yield return null;
        }
        
    }

    protected override void Update()
    {
        speed = 300f; //change speed
        base.Update();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    //varibles
    Rigidbody2D rb;
    bool playerSelected;
    bool clickedOnSelf;
    protected float speed = 250f;
    protected Vector2 jumpForce = new Vector2 (0, 50);
    public GameObject highlight;

    // Start is called before the first frame update
    void Start()
    {
        //instantiate rigidbody and set selected to false
        rb = gameObject.GetComponent<Rigidbody2D>();
        Selected(false);
    }

    public void Selected(bool value)
    {
        //when selected show highlight
        playerSelected = value;
        highlight.SetActive(playerSelected);
    }

    protected virtual void Update()
    {
        if (playerSelected)//allow movement if selected
        {
            Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), 0) * speed * Time.deltaTime;
            rb.AddForce(movement);
        }
        
        if (Input.GetMouseButtonDown(1) && playerSelected)
        {
            Jump();
        }
    }

    private void OnMouseDown() //if clicked on then selected is true
    {
        PlayerSwap.pickSelectedPlayer(this);
    }

    protected virtual void Jump() //jumping function
    {
        rb.AddForce(jumpForce);
    }

    
}

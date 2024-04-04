using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    Rigidbody2D rb;
    bool playerSelected;
    bool clickedOnSelf;
    public float speed = 250f;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), 0) * speed * Time.deltaTime;
        rb.AddForce(movement);
    }
}

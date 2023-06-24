using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    float speed = 5f;
    float inputHorizontal;
    float inputVertical;

    bool grounded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(Vector3.up * 500);
            grounded = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            grounded = true;
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(inputHorizontal * speed, rb.velocity.y);
    }
}

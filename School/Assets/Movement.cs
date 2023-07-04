using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jump;
    public float rayLength;
    public float offset;
    public bool isGrounded = false;
    public bool canJump = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastGroundCheck();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    void RaycastGroundCheck()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.down), rayLength, LayerMask.NameToLayer("Ground"));
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.down * rayLength), Color.red);

        if(hit.collider != null)
        {
            if(hit.collider.gameObject.tag == "Ground")
            {
                Debug.Log("Floor");
                isGrounded = true;
            }
            else
            {
                Debug.Log("Air");
                isGrounded = false;
            }
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isGrounded = true;
        }
    }
}

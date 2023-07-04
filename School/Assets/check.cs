using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    private float rotateSpeed = 20f;
    private Vector3 horiMovement;

    [SerializeField] float sspeed;
    Rigidbody2D rb;
    public GameObject rayObj;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horiMovement = new Vector3(0f, 0f, -Input.GetAxis("Horizontal"));
        transform.Rotate(horiMovement * rotateSpeed * Time.deltaTime);

        if (Input.GetKeyDown("space"))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 2f);

            if (hit)
            {
                Debug.Log("Hit : "  +hit.collider.name);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float vertical;
    float horizontal;
    float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5.0f;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed*horizontal, vertical*speed);
    }
}

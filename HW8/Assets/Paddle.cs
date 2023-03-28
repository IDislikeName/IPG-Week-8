using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up))
        {
            rb.velocity = new Vector2(0, speed);
        }
        else if(Input.GetKey(down))
        {
            rb.velocity = new Vector2(0, -speed);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
        if (transform.position.y >= 3.5f)
        {
            transform.position = new Vector2(transform.position.x, 3.5f);
        }
        if (transform.position.y <= -3.5f)
        {
            transform.position = new Vector2(transform.position.x, -3.5f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("P1Goal"))
        {
            GameManager.instance.P1score++;
            GameManager.instance.ballnum--;
            Destroy(gameObject);
        }
        else if (collision.CompareTag("P2Goal"))
        {
            GameManager.instance.P2score++;
            GameManager.instance.ballnum--;
            Destroy(gameObject);
        }
    }
}

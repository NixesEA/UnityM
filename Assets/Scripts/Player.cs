using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float movement;
    public float movementSpeed;

    float minY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        minY = Camera.main.ScreenToWorldPoint(new Vector2(0f, 0f)).y + 0.3f;

        if(transform.position.y < minY)
        {
            if (Bonus.life > 0)
            {
                Bonus.life--;
                Vector2 velocity = rb.velocity;
                velocity.y = 13f;
                rb.velocity = velocity;

                transform.position = new Vector2(-transform.position.x, minY + 10f);
            }
            else
            {
                Debug.Log("Death");
            }
        }

        if (transform.position.x < -7f || transform.position.x > 7f)
        {
            transform.position = new Vector2(-transform.position.x, transform.position.y);
        }
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}

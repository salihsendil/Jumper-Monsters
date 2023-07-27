using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 15f;
    float verticalSpeed;
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        FlipSprite();
    }

    private void Movement()
    {
        verticalSpeed = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(speed * verticalSpeed, rb2d.velocity.y);
    }
    private void FlipSprite()
    {
        if (Mathf.Abs(rb2d.velocity.x) > Mathf.Epsilon)
        {
            transform.localScale = new Vector2(Mathf.Sign(rb2d.velocity.x), 1f);
        }
    }
}

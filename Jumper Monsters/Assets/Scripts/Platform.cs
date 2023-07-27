using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] float jumpSpeed = 20f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Rigidbody2D playerRb2d = other.collider.GetComponent<Rigidbody2D>();

        if (other.relativeVelocity.y < Mathf.Epsilon)
        {
            if (playerRb2d != null)
            {
                playerRb2d.velocity = new Vector2(playerRb2d.velocity.x, jumpSpeed);
            }
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementGround : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    void Update()
    {
        rb.velocity = Vector2.down * speed;
    }
}

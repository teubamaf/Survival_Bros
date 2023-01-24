using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentMover : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [SerializeField]
    private float moveSpeed = 5f;

    public Vector2 MovementInput { get; set; }

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb2d.velocity = MovementInput * moveSpeed;
    }

}

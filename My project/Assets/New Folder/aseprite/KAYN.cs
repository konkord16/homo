using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KAYN : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
    }


    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
     }
}

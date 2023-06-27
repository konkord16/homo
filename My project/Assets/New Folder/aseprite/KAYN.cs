using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayn : MonoBehaviour
{
    public float speed=3f;
    private Vector2 direction;
    public Rigidbody2D rb;
    public Transform attackPoint;
    public float attackRange = 0.66f;
    public LayerMask enemy;
    public int AD = 40;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
        
    }


        void FixedUpdate()
        {
            rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);

        }
        void Attack()
        {
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemy);
            foreach (Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<NewBehaviourScript>().takeDamage(AD);
            }
        }
    

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}

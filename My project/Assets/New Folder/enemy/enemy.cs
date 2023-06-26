using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 2f;
    public Transform player;
    public int hp = 100;
   
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    public void takeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.fixedDeltaTime);

    }

    
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDamage : MonoBehaviour
{
    public bool isDead;
    public Animator explosionAnim;
    private Rigidbody2D rb;
    public int damage;
    public PlayerHealth playerHealth;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isDead = false;
        explosionAnim.SetBool("isDead", isDead);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            isDead = true;
            explosionAnim.SetBool("isDead", isDead);
            Debug.Log("I am Dead!");
            Invoke("OnDestroy", 0.8f);
        }
    }

    private void OnDestroy()
    {
        playerHealth.TakeDamage(damage);
        Destroy(gameObject);
    }
}

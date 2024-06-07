using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public int health = 100;

    private int MAX_HEALTH = 100;

    bool isDead;
    public Animator deadAnim;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isDead = false;
        health = MAX_HEALTH;
    }

    public void SetHealth(int maxHealth, int health)
    {
        this.MAX_HEALTH = maxHealth;
        this.health = health;
    }

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }

    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentException("Cannot have negative healing");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;

        if(wouldBeOverMaxHealth)
        {
            this.health = MAX_HEALTH;
        }
        else
        {
            this.health += amount;
        }

        this.health += amount;
    }

    private void Die()
    {
        isDead = true;
        deadAnim.SetBool("isDead", isDead);
        Debug.Log("I am Dead!");
        Invoke("OnDestroy", 0.3f);
    }

    private void OnDestroy()
    {
        // Destroy(gameObject);
        // Time.timeScale = 0f;

    }
    

}

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Garlic : MonoBehaviour
{
    public bool isDead;
    public int damage;
    public PlayerHealth playerHealth;
    float timer;

    void Start()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("I am Dead!");

            timer += Time.deltaTime;

            if (timer >= 2)
            {
                playerHealth.TakeDamage(damage);
                timer = 0;
            }
           
        }
    }
}

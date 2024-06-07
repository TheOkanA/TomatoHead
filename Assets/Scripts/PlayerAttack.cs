using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private GameObject attackArea = default;

    public bool attacking = false;
    private float timeToAttack = 0.25f;
    private float timer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
        attackArea.SetActive(attacking);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    Attack();
        //}



        if (attacking)
        {
            timer += Time.deltaTime;

            if(timer >= timeToAttack )
            {
                timer = 0f;
                attacking = false;
                attackArea.SetActive(attacking);
            }
        }
    }

    public void Attack()
    {
        attacking = true;
        attackArea.SetActive(attacking);
    }
}

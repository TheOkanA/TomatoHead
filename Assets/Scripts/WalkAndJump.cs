using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAndJump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 3f;
    public float jump = 2f;
    bool isWalking = false;
    public bool isAttacking = false;
    public bool groundCheck;
    bool wall;
    public Animator walkAnim;
    public Animator attackAnim;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        if (moveInput < 0)
        {
            FlipToRight();
        }
        if (moveInput > 0)
        {
            FlipToLeft();
        }

        if (moveInput != 0)
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }


        /*if (Input.GetButtonDown("Fire1"))
        {
            isAttacking = true;
        }
        else
        {
            isAttacking = false;
        }*/
        attackAnim.SetBool("isAttacking", isAttacking);

        walkAnim.SetBool("isWalking", isWalking);

        if (Input.GetKeyDown(KeyCode.W) && groundCheck == true)
        {
            rb.AddForce(new Vector3(rb.velocity.x, jump));
        }

    }


        private void isAttackingFalse()
        {
          isAttacking = false;
        }


        public void fireButton()
        {
            isAttacking = true;
            Invoke("isAttackingFalse", 0.3f);
        }


        void OnTriggerEnter2D(Collider2D other)
        {
             if (other.CompareTag("Map"))
             {
                groundCheck = true;
             }
        }

         void OnTriggerStay2D(Collider2D other)
         {
            if (other.CompareTag("Map"))
            {
                groundCheck = true;
            }
         }

        void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Map"))
            {
            groundCheck = false;
            }
        }

    void FlipToRight()
        {
            //facingRight = true;
            transform.localScale = new Vector3(-1, 1, 1);
        }

        void FlipToLeft()
        {
            //facingRight = false;
            transform.localScale = new Vector3(1, 1, 1);
        }



 
}

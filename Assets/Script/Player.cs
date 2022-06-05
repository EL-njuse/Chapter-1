using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;

    public float speed;
    public bool canMove = true;


    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            Movement();
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

    }

    void Movement()
    {
        float horizontalmove = Input.GetAxis("Horizontal");
        float facedirection = Input.GetAxisRaw("Horizontal");

        if (horizontalmove != 0)
        {
            rb.velocity = new Vector2(horizontalmove * speed, rb.velocity.y);
            anim.SetFloat("walking",Mathf.Abs(horizontalmove));
        }

        if (facedirection != 0)
        {
            transform.localScale = new Vector3(facedirection, 1, 1);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperCat : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator anim;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public float speed;
    public float jumpPower;
    // Update is called once per frame
    void Update()
    {
        // jump
        if (Input.GetKeyDown(KeyCode.UpArrow) && !anim.GetBool("UpperisJumping"))
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            anim.SetBool("UpperisJumping", true);
        }
        // move
        if (Input.GetKey(KeyCode.RightArrow)) { transform.Translate(Vector2.right * speed); }
        if (Input.GetKey(KeyCode.LeftArrow)) { transform.Translate(-Vector2.right * speed); }
        
        

        //animation
        if (Input.GetKey(KeyCode.RightArrow))
            anim.SetBool("Upperismoving", true);
        else if (Input.GetKey(KeyCode.LeftArrow))
            anim.SetBool("Upperismoving", true);
        else 
            anim.SetBool("Upperismoving", false);
    }
    void FixedUpdate()
    {
        //Landing Platform
        if (rigid.velocity.y < 0)
        {
            Debug.DrawRay(rigid.position, Vector3.down, new Color(0, 1, 0));

            RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Platform"));

            if (rayHit.collider != null)
            {
                if (rayHit.distance < 0.5f)
                    anim.SetBool("UpperisJumping", false);
            }
        
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 2; //para el movimiento horizontal
    public float jumpSpeed = 3;
    Rigidbody2D rb2D;           //referencia al RigidBody

    public bool betterJump = false; //saldo mejorado (sensible)
    public float fallMultiplier = 0.5f;
    public float lowJumpMultiplier = 1f;

    public SpriteRenderer spriteRenderer; //para voltear a donde mira el personaje dependiendo de la dirección de movimiento

    public Animator animator; //para cambiar la animacion de cuando está quieto o caminando

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); 
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y); //cuando no hay movimiento 
            animator.SetBool("Run", false);
        }

        if (Input.GetKey("space") && CheckGround.isGrounded) //para el salto
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }

        //ifs para cambio de booleanos de los que dependen las animaciones
        if (CheckGround.isGrounded == false)
        {
            animator.SetBool("Jump", true); 
            animator.SetBool("Run", false);
        }
        if(CheckGround.isGrounded == true)
        {
            animator.SetBool("Jump", false);
        }

        //if para el cambio a tipo de salto mejorado
        if (betterJump)
        {
            if (rb2D.velocity.y<0)
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
            }

            if (rb2D.velocity.y > 0 && !Input.GetKey("space"))
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
            }
        }

    }
}

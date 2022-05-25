using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance; 
    public int contador; 
    public float moveSpeed; 
    //Controlador de salto
    public float jumpForce;
    private bool canDoubleJump;

    //Hace referencia al componente rigitBody
    public Rigidbody2D theRB; 

    //Collider con el ground
    private bool isGrounded; 
    public Transform groundCheckPoint; 
    public LayerMask whatIsGround;

    //Player roll
    private Vector2 rollPosition;
    private bool rollReady; 

    //Animations
    public Animator anim; 
    private SpriteRenderer theSR; 
    private Transform theTS; 
    public bool isDead; 


    public float knockBackLength, knockBackForce; 
    private float knockBackCounter; 

    void Start()
    {
        anim = GetComponent<Animator> (); 
        theSR = GetComponent<SpriteRenderer> (); 

    }
    public void Awake( ){
        instance = this; 
    }
    void Update()
    {
        if(knockBackCounter <= 0){
//Accede a la velocidad de los cuerpos rigidos
        theRB.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"), theRB.velocity.y);
        
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .2f, whatIsGround); 
        if(isGrounded) {
            canDoubleJump = true; 
        }
        //Salto 
        if(Input.GetButtonDown("Jump")){
            if(isGrounded){ 
            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce); 
            } else { 
                if(canDoubleJump){
                    jumpForce = 5; 
                theRB.velocity = new Vector2(theRB.velocity.x, jumpForce); 
                  canDoubleJump = false; 
                }
            }
        } 
        if(theRB.velocity.x < 0){ 
            theSR.flipX = true; 

        } else if (theRB.velocity.x > 0) { 
            theSR.flipX = false; 
        }
        } else {
            knockBackCounter -= Time.deltaTime;
            if(!theSR.flipX){
                theRB.velocity=new Vector2(-knockBackForce, theRB.velocity.y);
            } else {
                theRB.velocity=new Vector2(knockBackForce, theRB.velocity.y);

            }
        }
        

 

        //Animaciones
   
        anim.SetFloat("moveSpeed", Mathf.Abs(theRB.velocity.x)); 
    }


    public void KnockBack( ){
        knockBackCounter = knockBackLength;
        theRB.velocity = new Vector2(0f, knockBackForce);
    }
}

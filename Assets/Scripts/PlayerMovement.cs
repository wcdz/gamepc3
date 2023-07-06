using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controlador;
    public Animator animator;
    public float velocidad = 40f;
    float movimientoHorizontal = 0f;
    bool jump = false; //Auxiliar para el salto    
    bool crouch = false; //Auxiliar para agacharse
    public AudioSource SonidoDeSalto;

    void Start(){
        SonidoDeSalto = GetComponent<AudioSource>();
    }

    void Update(){
        movimientoHorizontal = Input.GetAxisRaw("Horizontal")*velocidad;
        animator.SetFloat("Speed",Mathf.Abs(movimientoHorizontal));

        if(Input.GetButtonDown("Jump")){
            jump = true;
            animator.SetBool("IsJumping", true);
            SonidoDeSalto.Play();
        }
        if(Input.GetButtonDown("Crouch")){
            crouch = true;            
        }else if(Input.GetButtonUp("Crouch")){
            crouch = false;
        }
    }

    public void OnLanding(){
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching){
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate(){
        controlador.Move(movimientoHorizontal*Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}

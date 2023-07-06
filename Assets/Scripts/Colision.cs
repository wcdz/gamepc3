using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Boss")){
            Debug.Log("GAME OVER");
            //Application.Quit(); //Juego ya implementado
            UnityEditor.EditorApplication.isPlaying = false; // Durante la edición
        }

    }
    
    /*
    private void OnCollisionStay2D(Collision2D collision){
        if(collision.gameObject.name == "enemigo"){
            Debug.Log("Espera");
        }
    }
    private void OnCollisionExit2D(Collision2D collision){
        if(collision.gameObject.name == "enemigo"){
            Debug.Log("Salio");
        }
    }*/
}

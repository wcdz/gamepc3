using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoProyectil : MonoBehaviour
{
    public float velocidad = 30f;
    public Rigidbody2D rb;
    public int ataque = 40;

    void Start()
    {
        rb.velocity = transform.right * velocidad;
    }

    void OnTriggerEnter2D(Collider2D objeto){
        Enemigo enemigo = objeto.GetComponent<Enemigo>();
        if(enemigo != null){
            /*Codigo para la puntuacion*/
        
            /*------------------------*/
            enemigo.Atacado(ataque);
        }
        Destroy(gameObject);
    }

}

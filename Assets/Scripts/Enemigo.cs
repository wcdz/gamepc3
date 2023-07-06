using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int saludEnemigo = 100;
    public GameObject elemento;

    public void Atacado(int damage){
        saludEnemigo -= damage;
        Puntuacion.instance.Aumentar();
        if(saludEnemigo <= 0){ Muere();}
    }

    void Muere(){
        Instantiate(elemento, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

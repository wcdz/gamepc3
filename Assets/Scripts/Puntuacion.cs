using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuacion : MonoBehaviour
{
    public static Puntuacion instance;
    public TMP_Text puntuacion;
    int puntos = 0;

    private void Awake(){
        instance = this;
    }

    void Start()
    {
            puntuacion.text = puntos.ToString() + " puntos";
    }

    public void Aumentar(){
        puntos += 10;
        puntuacion.text = puntos.ToString() + " puntos";
    }
}

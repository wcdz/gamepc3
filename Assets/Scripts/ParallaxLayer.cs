using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ParallaxLayer : MonoBehaviour
{
    public float parallaxFactor;

    public void Move(float delta){
        Vector3 posNue = transform.localPosition;
        posNue.x -= delta * parallaxFactor;
        transform.localPosition = posNue;
    }
}
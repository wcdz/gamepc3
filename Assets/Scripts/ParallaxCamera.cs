using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ParallaxCamera : MonoBehaviour
{
    public delegate void ParallaxCameraDelegate(float delta);
    public ParallaxCameraDelegate onCameraTrans;
    private float posAnt;    
    
    void Start(){
        posAnt = transform.position.x;
    }

    void FixedUpdate()
    {
        if (transform.position.x != posAnt){
            if(onCameraTrans != null){
                float d = posAnt - transform.position.x;
                onCameraTrans(d);
            }
            posAnt = transform.position.x;
        }
    }
}
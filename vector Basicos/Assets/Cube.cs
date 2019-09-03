using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
 [SerializeField]private Vector3 velocidad=new Vector3(0,0,0);
 [SerializeField]private Vector3 acceleracion=new Vector3(0,0,0);

    void Start()
    {
    
    }

   
    void Update()
    {
        transform.position+=velocidad*Time.deltaTime;;
        velocidad+=acceleracion*Time.deltaTime;
        if(transform.position.y<-5){
            Debug.Log("toco el piso");
            velocidad.y=-velocidad.y;
        }
        if(transform.position.x<-6||transform.position.x>6){
            velocidad.x*=-1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
  float timer=0;
  float TimeTOWait=3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>TimeTOWait){
            timer=0;
            Action() ;
            RandomisePosition();
        }
        timer+=Time.deltaTime;
    }
    void Action(){
Debug.Log("ACCION");
    }
     public void RandomisePosition(){
        float X=Random.Range(-5,5);
        float y=Random.Range(-5,5);
        transform.position=new Vector3(X,y,0);
    }
}

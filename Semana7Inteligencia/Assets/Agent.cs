using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    public float MaxSteer;
    public float MaxSpped;
    private Vector3 velocity = Vector3.zero;
    private Vector3 desired;
    public Transform objetivo;

    private Vector3 steer;

    void Update()
    {
     
        seek(this.gameObject, objetivo);
    }
    public void seek(GameObject actual, Transform objetivo)
    {

        desired = Vector3.zero;
        desired = (objetivo.transform.position - actual.transform.position).normalized * MaxSpped;

        steer = Vector3.ClampMagnitude(desired - velocity, MaxSteer);
        velocity+=steer*Time.deltaTime;
        transform.position+=velocity*Time.deltaTime;

        transform.up =velocity;

    }

}

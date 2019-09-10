using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    Vector3 velocity = Vector3.zero;
    Vector3 desired=Vector3.zero;
    Vector3 steer = Vector3.zero;

    float maxSpeed = 5; 
    float maxSteer = 5;
    Transform target;    

    private int Radius = 1;

    [SerializeField]
    private Transform Target;

    private bool IsEnter = false;
 
    void Update()
    {
        //This makes it move
        Movement();
        //This makes collision with center
        Collision();
        //This is for the borders 
        OutOfRanges();

    }

    void Movement(){

        target = GameObject.Find("Target").transform;

        desired = -(target.position -transform.position).normalized*maxSpeed;
        steer = Vector3.ClampMagnitude(desired-velocity, maxSteer); 

    velocity += steer*Time.deltaTime;
    transform.position += velocity*Time.deltaTime;
    }

    void Collision(){
     float distance = (Target.position - transform.position).magnitude;
        if (distance <= Radius)
        {
            if (!IsEnter)
            {
                IsEnter = true;
               Destroy(gameObject);
               print("Toco el centro");
            }
        }
        else
        {
            if (IsEnter)
            {
                IsEnter = false;
                
            }
        }
    }

    void OutOfRanges(){
        if(transform.position.x >9.41f){
            Destroy(gameObject);
            print("se salio del borde");
        } 
        if(transform.position.x <-9.41f){
             Destroy(gameObject);
            print("se salio del borde");
        }
        if(transform.position.y > 5.58){
            Destroy(gameObject);
            print("se salio del borde");
        }
        if(transform.position.y <- 5.58){
            Destroy(gameObject);
            print("se salio del borde");
        }
        
    }
}

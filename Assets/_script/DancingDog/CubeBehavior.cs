﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;

public class CubeBehavior : MonoBehaviour
{
    //public Transform player;
    Rigidbody rb;
    public float speed = 30;
    int danceState = 1;

    

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SequencerRotate(float Target)
    {
        Target = speed;
        transform.Rotate(Vector3.up);
        
    }

    public void OnCollisionEnter (Collision c)
    {
        Debug.Log("Collide!");
    }

    public void OnTriggerStay (Collider c)
    {
        Debug.Log("SomethingStay");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

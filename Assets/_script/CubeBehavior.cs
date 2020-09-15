using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;

public class CubeBehavior : MonoBehaviour
{
    public Transform player;
    Rigidbody rb;
    public float Speed = 30;
    int danceState = 1;

    Vector3 FaceOri;
    [SerializeField] Vector3 Face1;
    [SerializeField] Vector3 Face2;
    [SerializeField] Vector3 Face3;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        FaceOri = transform.eulerAngles;
    }

    public void ChordDancing(float Target)
    {
        Debug.Log("I'm dancing!!!!");
        if (danceState == 1)
        {
            danceState = 2;
            transform.eulerAngles = Vector3.Lerp(FaceOri, Face1, Speed * Time.deltaTime);
        }
        if (danceState == 2)
        {
            danceState = 3;
            transform.eulerAngles = Vector3.Lerp(Face1, Face2, Speed * Time.deltaTime);
        }
        if (danceState == 3)
        {
            danceState = 1;
            transform.eulerAngles = Vector3.Lerp(Face2, FaceOri, Speed * Time.deltaTime);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

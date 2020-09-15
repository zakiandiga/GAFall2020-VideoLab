using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;

public class SphereBehavior : MonoBehaviour
{
    Rigidbody rb;
    bool isJump = false;
    public static float knobOne = 0;
    public KeyCode jump;
    public float noteNumber;
    public float JumpForce = 10;
    //public event EventHandler CubeJump;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SphereJump(float Power)
    {
        Power = JumpForce;
        Debug.Log("CubeJump CALLED!!!");
        print(Power);
        rb.AddForce(0, Power, 0, ForceMode.Impulse);
        isJump = false;
    }

    // Update is called once per frame
    /*
    void Update()
    {
        if(Input.GetKeyDown (jump))
        {
            isJump = true;
            CubeJump(10);
        }
    }
    */
}

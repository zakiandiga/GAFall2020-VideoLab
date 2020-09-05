using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    Rigidbody rb;
    bool isJump = false;
    public static float knobOne = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void CubeJump()
    {
        rb.AddForce(0, 100, 0, ForceMode.Impulse);
        isJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isJump == true)
        {
            CubeJump();
        }
    }
}

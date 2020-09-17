using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugBehavior : MonoBehaviour
{
    Rigidbody rb;
    float moveSpeed = 7f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.name == "Cube")
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = Vector3.right * moveSpeed * -1;
    }
}

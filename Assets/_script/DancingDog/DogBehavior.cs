using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DogBehavior : MonoBehaviour
{
    Rigidbody rb;
    NavMeshAgent agent;

    public KeyCode jump;
    private bool isGrounded = true;

    float moveDist = 20f;
    float jumpForce = 10f;

    private Vector3 originalPos;
    private Vector3 destination;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();        
        agent = GetComponent<NavMeshAgent>();
        originalPos = transform.position;
        destination = originalPos;

    }

    void NoteMove()
    {
        Debug.Log("Moving with note!!");
        float movX, movZ;
        movX = transform.position.x + Random.Range(-5f, 5f);
        movZ = transform.position.z + Random.Range(-5f, 5f);
        destination = new Vector3(movX, transform.position.y, movZ);
        agent.SetDestination(destination);
    }
    
    void NoteJump()
    {
        
        agent.enabled = false;
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
        
        
    }

    /*void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
            agent.enabled = true;
        }
    }*/

    void Update()
    {
        if(Input.GetKeyDown(jump))
        {
            NoteMove(); //Temporary
            
        }
    }
}

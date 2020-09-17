using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogDance : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]float jumpForce = 10f;
    bool isGrounded = true;

    float stepForce = 5;
    Vector3 stepDir;

    //private yRot targetRot = yRot.pos1;
    Animator anim;

    [SerializeField] float[] rotList = new float[] { 90, 180, 270 };
    float rotSpeed = 50;

// Start is called before the first frame update
void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
            
        }
    }

    public void NoteJump(float force)
    {
        if(isGrounded)
        {
            force = jumpForce;
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            isGrounded = false;
        }
        
    }

    public void NoteRotate(float speed)
    {
        speed = rotSpeed;
        float yRot = transform.eulerAngles.y;
        Vector3 originalRot = transform.eulerAngles;
        Vector3 destinationRot = originalRot;
        //float randomRot = 
        destinationRot.y = rotList[Random.Range(0, rotList.Length)];
        //transform.eulerAngles = destinationRot;
        transform.eulerAngles = Vector3.Lerp(originalRot, destinationRot, rotSpeed * Time.deltaTime);
        Debug.Log("TURNING to " + destinationRot);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            NoteRotate(10); //Temporary

        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballOri;
    GameObject ball;

    [SerializeField] Vector3[] ballPos = new Vector3[5];

    // Start is called before the first frame update
    void Start()
    {
        
    }




    public void PopBall(float f)
    {
        f = 0;
        ball = Instantiate(ballOri, ballPos[Random.Range(0, ballPos.Length)], this.transform.rotation);
        ball.SetActive(true);
        
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugSpawn : MonoBehaviour
{
    public GameObject bugOri;
    GameObject bug;
    

    

    void Start()
    {
        //bug = Instantiate(bugOri, this.transform.position, Quaternion.identity);
    }

    public void SpawnBug (float y)
    {
        y = 0;
        bug = Instantiate(bugOri, this.transform.position, this.transform.rotation);
        bug.SetActive(true);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnBug(10); //Temporary

        }
    }
}

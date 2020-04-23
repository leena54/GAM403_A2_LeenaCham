using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{

    public Transform theDest;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            
            GetComponent<Rigidbody>().isKinematic = true;
            this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("Destination").transform;
        }

        else if(Input.GetKeyUp("space"))
        {
            this.transform.parent = null;
            
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}

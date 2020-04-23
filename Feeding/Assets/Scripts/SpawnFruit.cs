using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour
{
    public GameObject fruit;
    
   
    void Start()
    {
        
    }

    // Update is called once per frame
    
        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.tag == ("food"))
            {
              fruit.transform.position = new Vector3(6, 1, 3);
            }
        }
        
    
}

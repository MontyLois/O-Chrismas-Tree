using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hang_decoration : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="sapin")
        {
            Debug.Log("hang decoration");
            Rigidbody rb = this.GetComponent<Rigidbody>();
            
            
        }
    }
}

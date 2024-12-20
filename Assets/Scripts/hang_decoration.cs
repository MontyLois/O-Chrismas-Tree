using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class hang_decoration : MonoBehaviour
{
    [SerializeField] 
    private XRGrabInteractable script;
    
    private Rigidbody rb;

    
    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag=="sapin"&&!script.isSelected)
        {
            rb.useGravity = false;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag=="sapin")
        {
            rb.useGravity = true;
        }
    }
}

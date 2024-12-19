using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class hang_star : MonoBehaviour
{
    [SerializeField] 
    private XRGrabInteractable script;

    [SerializeField] 
    private Transform star_position;

    private Rigidbody rb;
    private Transform tr;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        tr = this.transform;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag=="sapin"&&!script.isSelected)
        {
            rb.useGravity = false;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            tr.SetPositionAndRotation(star_position.position, star_position.rotation);
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

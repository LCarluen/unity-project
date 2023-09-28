using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CenterOfGravity : MonoBehaviour
{
    public Vector3 CenterOfMass2;

    public bool Awake;
    protected Rigidbody r;

    void Start()
    {
        r = GetComponent<Rigidbody>();
    }
    void Update()
    {
        r.centerOfMass = CenterOfMass2;
        r.WakeUp();
        Awake = !r.IsSleeping();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position + transform.rotation * CenterOfMass2, 0.1f);
    }
}

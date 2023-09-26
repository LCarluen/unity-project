using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CentreOfMass : MonoBehaviour
{

    public Vector3 CentreOfMass2;
    public bool Awake;
    protected Rigidbody r;


    void Start()
    {
        r = GetComponent<Rigidbody>();
    }


    void Update()
    {
        r.CentreOfMass = CentreOfMass2;
        r.WakeUp();
        Awake = !r.IsSleeping();
    }

    private void OnDrawGizmos()
    {
      Gizmos.color = Color.red;
      Gizmos.DrawSphere(transform.position + transform.rotation * CentreOfMass2, 1f);
    }
}

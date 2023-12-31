using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RearWingDownforce : MonoBehaviour
{
    public Rigidbody car;
    [Range(0,10)] public float downforceValue = 5.0f;

    void Update()
    {
        float carSpeed = car.velocity.magnitude;
        float downforce = carSpeed * downforceValue;

        Vector3 downforceVector = -car.velocity.normalized * downforce;
        car.AddForce(downforceVector, ForceMode.Force);
    }

}

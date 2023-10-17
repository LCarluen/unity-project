using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour {

   [SerializeField] WheelCollider frontRight;
   [SerializeField] WheelCollider frontLeft;
   [SerializeField] WheelCollider backRight;
   [SerializeField] WheelCollider backLeft;

   [SerializeField] Transform frontRightTransform;
   [SerializeField] Transform frontLeftTransform;
   [SerializeField] Transform backRightTransform;
   [SerializeField] Transform backLeftTransform;

   public float acceleration = 0f;
   public float reverse = 0f;
   public float brakingForce = 0f;
   public float maxTurnAngle = 0f;


   private float currentAcceleration = 0f; 
   private float currentBrakeForce = 0f;
   private float currentTurnAngle = 0f;

   private void FixedUpdate() {
        if (Input.GetKey(KeyCode.W))
          currentAcceleration = acceleration;
        else if (Input.GetKey(KeyCode.DownArrow))
            currentAcceleration = -500f;
        else
          currentAcceleration = 0f;


        if (Input.GetKey(KeyCode.S))
          currentBrakeForce = brakingForce;
        else
          currentBrakeForce = 0f;

      backRight.motorTorque = currentAcceleration;
      backLeft.motorTorque = currentAcceleration;

      frontRight.brakeTorque = currentBrakeForce;
      frontLeft.brakeTorque = currentBrakeForce;
      backRight.brakeTorque = currentBrakeForce;
      backLeft.brakeTorque = currentBrakeForce;

      currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
      frontLeft.steerAngle = currentTurnAngle;
      frontRight.steerAngle = currentTurnAngle;

      UpdateWheel(frontLeft, frontLeftTransform);
      UpdateWheel(frontRight, frontRightTransform);
      UpdateWheel(backLeft, backLeftTransform);
      UpdateWheel(backRight, backRightTransform);
   }

   void UpdateWheel(WheelCollider col, Transform trans) {

     Vector3 position;
     Quaternion rotation;
     col.GetWorldPose(out position, out rotation);

     trans.position = position;
     trans.rotation = rotation;
   }
}

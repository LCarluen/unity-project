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

   public float acceleration = 500f;
   public float brakingForce = 300f;
   public float maxTurnAngle = 15f;

   private float currentAcceleration = 0f;
   private float currentBrakeForce = 0f;
   private float currentTurnAngle = 0f;

   private void FixedUpdate() {
      // Get forward/reverse acceleration from the vertical axis (W and S keys)
      float accelerationInput = Input.GetAxis("Vertical");
      currentAcceleration = accelerationInput * acceleration;

      // Apply braking force if the spacebar is pressed
      if (Input.GetKey(KeyCode.Space))
          currentBrakeForce = brakingForce;
      else
          currentBrakeForce = 0f;

      // Apply acceleration to back wheels
      backRight.motorTorque = currentAcceleration;
      backLeft.motorTorque = currentAcceleration;

      // Apply braking force to all wheels
      frontRight.brakeTorque = currentBrakeForce;
      frontLeft.brakeTorque = currentBrakeForce;
      backRight.brakeTorque = currentBrakeForce;
      backLeft.brakeTorque = currentBrakeForce;

      // Steering
      currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
      frontLeft.steerAngle = currentTurnAngle;
      frontRight.steerAngle = currentTurnAngle;

      // Update wheel meshes
      UpdateWheel(frontLeft, frontLeftTransform);
      UpdateWheel(frontRight, frontRightTransform);
      UpdateWheel(backLeft, backLeftTransform);
      UpdateWheel(backRight, backRightTransform);
   }

   void UpdateWheel(WheelCollider col, Transform trans) {

     // Get wheel collider state
     Vector3 position;
     Quaternion rotation;
     col.GetWorldPose(out position, out rotation);

     // Set wheel transform state
     trans.position = position;
     trans.rotation = rotation;
   }
}

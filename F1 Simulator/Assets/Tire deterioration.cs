using UnityEngine;

public class TireDeterioration : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;
    public float initialTireHealth = 100f;
    public float tireDeteriorationRate = 20f;
    public float maxDeterioration = 100f;
    public float colliderCircumference = 3.14f * 0.5f * 2f;

    public float distanceTravelled = 0.0f;

void FixedUpdate()
{
    float angularVelocity = backLeft.rpm * colliderCircumference / 60.0f;
    distanceTravelled += angularVelocity * 0.5f * Time.deltaTime;

    if((distanceTravelled / initialTireHealth) >= 0.8f)
    {
        WheelFrictionCurve WFC;
        WFC = frontRight.sidewaysFriction;
        WFC = frontLeft.sidewaysFriction;
        WFC = backRight.sidewaysFriction;
        WFC = backLeft.sidewaysFriction;
        WFC.extremumValue = 2.5f;
        frontRight.sidewaysFriction = WFC;
        frontLeft.sidewaysFriction = WFC;
        backRight.sidewaysFriction = WFC;
        backLeft.sidewaysFriction = WFC;
    }

    if((distanceTravelled / initialTireHealth) >= 0.6f && (distanceTravelled / initialTireHealth) < 0.8f)
    {
        WheelFrictionCurve WFC;
        WFC = frontRight.sidewaysFriction;
        WFC = frontLeft.sidewaysFriction;
        WFC = backRight.sidewaysFriction;
        WFC = backLeft.sidewaysFriction;
        WFC.extremumValue = 2.7f;
        frontRight.sidewaysFriction = WFC;
        frontLeft.sidewaysFriction = WFC;
        backRight.sidewaysFriction = WFC;
        backLeft.sidewaysFriction = WFC;
    }

    if((distanceTravelled / initialTireHealth) >= 0.4f && (distanceTravelled / initialTireHealth) < 0.6f)
    {
        WheelFrictionCurve WFC;
        WFC = frontRight.sidewaysFriction;
        WFC = frontLeft.sidewaysFriction;
        WFC = backRight.sidewaysFriction;
        WFC = backLeft.sidewaysFriction;
        WFC.extremumValue = 2.9f;
        frontRight.sidewaysFriction = WFC;
        frontLeft.sidewaysFriction = WFC;
        backRight.sidewaysFriction = WFC;
        backLeft.sidewaysFriction = WFC;
    }

    if((distanceTravelled / initialTireHealth) >= 0.2 && (distanceTravelled / initialTireHealth) < 0.4)
    {
        WheelFrictionCurve WFC;
        WFC = frontRight.sidewaysFriction;
        WFC = frontLeft.sidewaysFriction;
        WFC = backRight.sidewaysFriction;
        WFC = backLeft.sidewaysFriction;
        WFC.extremumValue = 3.1f;
        frontRight.sidewaysFriction = WFC;
        frontLeft.sidewaysFriction = WFC;
        backRight.sidewaysFriction = WFC;
        backLeft.sidewaysFriction = WFC;
    }

    if((distanceTravelled / initialTireHealth) < 0.2f)
    {
        WheelFrictionCurve WFC;
        WFC = frontRight.sidewaysFriction;
        WFC = frontLeft.sidewaysFriction;
        WFC = backRight.sidewaysFriction;
        WFC = backLeft.sidewaysFriction;
        WFC.extremumValue = 3.3f;
        frontRight.sidewaysFriction = WFC;
        frontLeft.sidewaysFriction = WFC;
        backRight.sidewaysFriction = WFC;
        backLeft.sidewaysFriction = WFC;
    }

  }

}

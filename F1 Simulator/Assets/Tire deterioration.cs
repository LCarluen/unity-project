using UnityEngine;

public class TireDeterioration : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;
    public float initialTireHealth = 228800f;
    public float tireDeteriorationRate = 20f;
    public float maxDeterioration = 100f;
    public float colliderCircumference = 3.14f * 0.5f * 2f;
    public float wear = 0f;

    public float distanceTravelled = 0.0f;

    void FixedUpdate()
    {
        float angularVelocity = backLeft.rpm * colliderCircumference / 60.0f;
        distanceTravelled += angularVelocity * 0.5f * Time.deltaTime;
        wear = (distanceTravelled / initialTireHealth) / 1000f;

        WheelFrictionCurve WFC;

        if (wear <= 0.2f)
        {
            WFC = frontRight.sidewaysFriction;
            WFC.extremumValue = 3.3f;
            frontRight.sidewaysFriction = WFC;

            WFC = frontLeft.sidewaysFriction;
            WFC.extremumValue = 3.3f;
            frontLeft.sidewaysFriction = WFC;

            WFC = backRight.sidewaysFriction;
            WFC.extremumValue = 3.3f;
            backRight.sidewaysFriction = WFC;

            WFC = backLeft.sidewaysFriction;
            WFC.extremumValue = 3.3f;
            backLeft.sidewaysFriction = WFC;
        }
        else if (wear <= 0.4f && wear > 0.2f)
        {
            WFC = frontRight.sidewaysFriction;
            WFC.extremumValue = 3.1f;
            frontRight.sidewaysFriction = WFC;

            WFC = frontLeft.sidewaysFriction;
            WFC.extremumValue = 3.1f;
            frontLeft.sidewaysFriction = WFC;

            WFC = backRight.sidewaysFriction;
            WFC.extremumValue = 3.1f;
            backRight.sidewaysFriction = WFC;

            WFC = backLeft.sidewaysFriction;
            WFC.extremumValue = 3.1f;
            backLeft.sidewaysFriction = WFC;
        }
        else if (wear <= 0.6f && wear > 0.4f)
        {
            WFC = frontRight.sidewaysFriction;
            WFC.extremumValue = 2.9f;
            frontRight.sidewaysFriction = WFC;

            WFC = frontLeft.sidewaysFriction;
            WFC.extremumValue = 2.9f;
            frontLeft.sidewaysFriction = WFC;

            WFC = backRight.sidewaysFriction;
            WFC.extremumValue = 2.9f;
            backRight.sidewaysFriction = WFC;

            WFC = backLeft.sidewaysFriction;
            WFC.extremumValue = 2.9f;
            backLeft.sidewaysFriction = WFC;
        }
        else if (wear <= 0.8f && wear > 0.6f)
        {
            WFC = frontRight.sidewaysFriction;
            WFC.extremumValue = 2.7f;
            frontRight.sidewaysFriction = WFC;

            WFC = frontLeft.sidewaysFriction;
            WFC.extremumValue = 2.7f;
            frontLeft.sidewaysFriction = WFC;

            WFC = backRight.sidewaysFriction;
            WFC.extremumValue = 2.7f;
            backRight.sidewaysFriction = WFC;

            WFC = backLeft.sidewaysFriction;
            WFC.extremumValue = 2.7f;
            backLeft.sidewaysFriction = WFC;
        }
        else if (wear <= 1f && wear > 0.8f)
        {
            WFC = frontRight.sidewaysFriction;
            WFC.extremumValue = 2.5f;
            frontRight.sidewaysFriction = WFC;

            WFC = frontLeft.sidewaysFriction;
            WFC.extremumValue = 2.5f;
            frontLeft.sidewaysFriction = WFC;

            WFC = backRight.sidewaysFriction;
            WFC.extremumValue = 2.5f;
            backRight.sidewaysFriction = WFC;

            WFC = backLeft.sidewaysFriction;
            WFC.extremumValue = 2.5f;
            backLeft.sidewaysFriction = WFC;
        }
    }
}

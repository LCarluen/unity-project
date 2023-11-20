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
    private float colliderCircumference = (float)(3.14 * 0.5 * 2);


    
}



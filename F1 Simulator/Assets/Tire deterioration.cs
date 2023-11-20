using UnityEngine;

public class TireDeterioration : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;
    public float initialTireHealth = 100f; // Initial tire health
    public float tireDeteriorationRate = 0.1f;
    public float maxDeterioration = 100f;
    public WheelFrictionCurve sidewaysFriction;

    private float currentTireHealth;

    void Start()
    {
        currentTireHealth = initialTireHealth;
    }

    void Update()
    {
        float distanceTraveled = Vector3.Distance(transform.position, transform.position + transform.forward);
        DeteriorateTires(distanceTraveled * tireDeteriorationRate);

        // Check for tire blowout or replacement condition
        if (currentTireHealth <= 66f)
        {
            sidewaysFriction.extremumValue =
        }
        else if (currentTireHealth >= maxDeterioration)
        {
            ReplaceTire();
        }
    }

    void DeteriorateTires(float amount)
    {
        // Deteriorate the tires by the specified amount
        currentTireHealth -= amount;

        // Clamp the tire health to stay within valid range
        currentTireHealth = Mathf.Clamp(currentTireHealth, 0f, maxDeterioration);
    }

    private void FixedUpdate()
    {

    }
    }

}

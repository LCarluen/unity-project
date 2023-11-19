using UnityEngine;

public class TireDeterioration : MonoBehaviour
{
    public float initialTireHealth = 100f; // Initial tire health
    public float tireDeteriorationRate = 0.1f; // Rate at which the tires deteriorate per unit of distance
    public float maxDeterioration = 100f; // Maximum deterioration level

    private float currentTireHealth;

    void Start()
    {
        currentTireHealth = initialTireHealth;
    }

    void Update()
    {
        // Simulate tire deterioration based on distance traveled
        float distanceTraveled = Vector3.Distance(transform.position, transform.position + transform.forward);
        DeteriorateTires(distanceTraveled * tireDeteriorationRate);

        // Check for tire blowout or replacement condition
        if (currentTireHealth <= 0f)
        {
            BlowoutTire();
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

    void BlowoutTire()
    {
        // Implement the logic for a tire blowout
        Debug.Log("Tire blowout!");
        // You might want to add visual effects, play sound, etc.

        // For simplicity, respawn the vehicle for this example
        RespawnVehicle();
    }

    void ReplaceTire()
    {
        // Implement the logic for replacing a tire
        Debug.Log("Tire replacement!");
        // You might want to reset the tire health, play a replacement animation, etc.
        currentTireHealth = initialTireHealth;
    }

    void RespawnVehicle()
    {
        // Implement the logic for respawning the vehicle
        // For simplicity, reset the vehicle position for this example
        transform.position = Vector3.zero;
    }
}

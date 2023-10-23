using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Speedometer : MonoBehaviour
{
    public Rigidbody target;

    private float maxSpeed = 0.0f;

    public float minSpeedArrowAngle;
    public float maxSpeedArrowAngle;
    private int currentGear;

    [Header("UI")]
    public Text speedValue;
    public Text gearValue;
    public RectTransform needle;

    private float speed = 0.0f;
    private void Update()
    {

        speed = target.velocity.magnitude * 2.237f;

        if (speedValue != null)
        {
            speedValue.text = ((int)speed) + " mph";
        }

        if (needle != null)
        {
            needle.localEulerAngles =
               new Vector3(0, 0, Mathf.Lerp(minSpeedArrowAngle, maxSpeedArrowAngle, speed / maxSpeed));
        }


        if (speed <= 80.0f)
        {
            currentGear = 1;
            maxSpeed = 80.0f;
            gearValue.text = "" + currentGear;
        }

        else if (speed > 80.0f && speed <= 90.0f)
        {
            currentGear = 2;
            maxSpeed = 90.0f;
            gearValue.text = "" + currentGear;
        }

        else if (speed > 90.0f && speed <= 110.0f)
        {
            currentGear = 3;
            maxSpeed = 110.0f;
            gearValue.text = "" + currentGear;
        }

        else if (speed > 110.0f && speed <= 130.0f)
        {
            currentGear = 4;
            maxSpeed = 130.0f;
            gearValue.text = "" + currentGear;
        }

        else if (speed > 130.0f && speed <= 150.0f)
        {
            currentGear = 5;
            maxSpeed = 150.0f;
            gearValue.text = "" + currentGear;
        }

        else if (speed > 150.0f && speed <= 172.0f)
        {
            currentGear = 6;
            maxSpeed = 172.0f;
            gearValue.text = "" + currentGear;
        }

        else if (speed > 172.0f)
        {
            currentGear = 7;
            maxSpeed = 221.0f;
            gearValue.text = "" + currentGear;
        }

    }
}

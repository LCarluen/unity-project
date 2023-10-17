using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Speedometer : MonoBehaviour
{
    public Rigidbody target;

    public float maxSpeed = 0.0f;

    public float minSpeedNeedleAngle;
    public float maxSpeedNeedleAngle;

    public int RPM;
    public int MaxRPM;
    public int ChangeRPM;
    public float[] Gearbox;
    public Text gearText;
    public int currentGear;
    public bool CanShiftGear = false;
    public float torque;

    [Header("UI")]
    public Text speedValue;
    public RectTransform needle;

    private float speed = 0.0f;
    private void Update(Rigidbody rigidbody)
    {
        if (RPM >= ChangeRPM && CanShiftGear && currentGear != Gearbox.Length - 1)
        { currentGear++; CanShiftGear = false; }

        if (RPM <= 2000f && CanShiftGear && currentGear != 0)
        { currentGear--; CanShiftGear = false; }

        if (RPM < ChangeRPM)
        { CanShiftGear = true; }

        if (currentGear == Gearbox.Length - 1)
        { CanShiftGear = false; }

        speed = rigidbody.velocity.magnitude;
        GearBox();


        speed = target.velocity.magnitude * 2.237f;

        if (speedValue != null)
            speedValue.text = ((int)speed) + " mph";
        if (needle != null)
            needle.localEulerAngles =
                new Vector3(0, 0, Mathf.Lerp(minSpeedNeedleAngle, maxSpeedNeedleAngle, speed / maxSpeed));
    }
    void GearBox()
    {
        if (speed >= Gearbox[currentGear])
        { torque = 0f; }
        else
        { torque = 1f; }


    }

}

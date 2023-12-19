using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public static int minCount;
    public static int secCount;
    public static float millisecCount;
    public static string millisecDisplay;

    private float startTime;
    private float currentTime;
    private bool timerRunning = false;

    void Update()
    {
      if (timerRunning = true)
      {
        currentTime = Time.time - startTime;
        Debug.Log(currentTime);
      }
    }

    private void OnTriggerEnter(Collider other)
    {
      timerRunning = true;
      startTime = Time.time;
    }

}

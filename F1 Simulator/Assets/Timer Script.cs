using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimer : MonoBehaviour
{
    public Text lapTimeText;
    public Text bestLapTimeText;
    private float startTime;
    private float currentLapTime;
    private float bestLapTime = 5940;
    private int lapAmount = 0;

    void Start()
    {
        startTime = Time.time;
        currentLapTime = 0f;
        UpdateBestLapTime();
    }

    void Update()
    {
        currentLapTime = Time.time - startTime;
        UpdateLapTimeUI();
    }

    void OnTriggerEnter(Collider other)
    {
        lapAmount = lapAmount + 1;
        if (currentLapTime < bestLapTime && lapAmount > 1)
        {
          bestLapTime = currentLapTime;
          UpdateBestLapTime();
        }
        startTime = Time.time;
    }

    void UpdateBestLapTime()
    {
        int minutes = Mathf.FloorToInt(bestLapTime / 60);
        int seconds = Mathf.FloorToInt(bestLapTime % 60);
        float milliseconds = (bestLapTime * 100) % 100;

        bestLapTimeText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }

    void UpdateLapTimeUI()
    {
        int minutes = Mathf.FloorToInt(currentLapTime / 60);
        int seconds = Mathf.FloorToInt(currentLapTime % 60);
        float milliseconds = (currentLapTime * 100) % 100;

        lapTimeText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }
}

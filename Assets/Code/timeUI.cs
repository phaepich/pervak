using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class timeUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private void OnEnable()
    {
        timeManager.OnMinuteChanged += UpdateTime;
        timeManager.OnHourChanged += UpdateTime;
    }

    private void OnDisable()
    {
        timeManager.OnMinuteChanged -= UpdateTime;
        timeManager.OnHourChanged -= UpdateTime;
    }

    private void UpdateTime()
    {
        timeText.text = $"{timeManager.Hour:00}:{timeManager.Minute:00}";
    }
}

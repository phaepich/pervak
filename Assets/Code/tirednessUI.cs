using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class tirednessUI : MonoBehaviour
{
    public TextMeshProUGUI tirednessText;

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
        tirednessText.text = $"{tirednessManager.tiredness}%";
    }
}

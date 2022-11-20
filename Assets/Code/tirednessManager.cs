using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Transactions;
using UnityEngine.UIElements;

public class tirednessManager : MonoBehaviour
{
    public static float tiredness { get; private set; }
    void Start()
    {
        tiredness = 0f;
    }
    
    void Update()
    {
        while (tiredness != 100)
        {
            tiredness += Time.deltaTime * 4;
        }
        timeManager.OnMinuteChanged?.Invoke();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Transactions;
using UnityEngine.UIElements;

    public class timeManager : MonoBehaviour
    {
        public static Action OnMinuteChanged;
        public static Action OnHourChanged;
        public static int Minute { get; private set; }
        public static int Hour { get; private set; }
        private float minuteToRealTime = 1f;
        public float timer;
        void Start()
        {
            Minute = 59;
            Hour = 11;
            timer = minuteToRealTime;
        }
        
        void Update()
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Minute++;
                OnMinuteChanged?.Invoke();
                if (Minute >= 60)
                {
                    Hour++;
                    Minute = 0;
                    OnHourChanged?.Invoke();
                }

                timer = minuteToRealTime;
            }
        }
    }

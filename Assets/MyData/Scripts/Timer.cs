using UnityEngine.UI;
using System.Collections;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    int countDownTimer = 123;
    public Text timerUI;

     void Start()
    {
        countDownTime();
    }
    void countDownTime()
    {
        if (countDownTimer > 0)
        {
            TimeSpan convertTime = TimeSpan.FromSeconds(countDownTimer);
            timerUI.text = "Time left " + convertTime.Minutes + " : " + convertTime.Seconds;
            countDownTimer--;
            Invoke("countDownTime", 1.0f);
        }
        else
        {
            timerUI.text = "Game over";
        }
    }
}
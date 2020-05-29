using UnityEngine.UI;
using System.Collections;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    int countDownTimer = 30;
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
            timerUI.text = "TIME LEFT " + convertTime.Minutes + " : " + convertTime.Seconds;
            countDownTimer--;
            Invoke("countDownTime", 1.0f);
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
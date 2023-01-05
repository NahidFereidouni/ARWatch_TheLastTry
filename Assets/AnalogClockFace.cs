using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class AnalogClockFace : MonoBehaviour
{
    public GameObject clockSecondParent;
    public GameObject clockMinuteParent;
    public GameObject clockHourParent;
    string oldSeconds;

    private void Update()
    {
        string seconds = DateTime.Now.ToString("ss");


        if (seconds != oldSeconds)
        {
            UpdateTimer();
        }
        oldSeconds = seconds;
    }

    private void UpdateTimer()
    {
        // integer variables to get the value of the current time, these are then used as the value for how many degrees the hands rotate
        int secondsInt = int.Parse(DateTime.Now.ToString("ss"));
        int minutesInt = int.Parse(DateTime.Now.ToString("mm"));
        int hoursInt = int.Parse(DateTime.Now.ToString("hh"));
        print(hoursInt + " : " + minutesInt + " : " + secondsInt);

        //// code for rotating the watch hands based on real time of system
        clockSecondParent.transform.localRotation = Quaternion.Euler(0, 180, secondsInt * -6);
        clockMinuteParent.transform.localRotation = Quaternion.Euler(0, 180, minutesInt * -6);
        clockHourParent.transform.localRotation = Quaternion.Euler(0, 180, hoursInt * -360 / 12);
        
    }

}

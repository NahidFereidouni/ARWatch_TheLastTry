using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;



public class ScriptCurrentDate : MonoBehaviour
{
    [SerializeField] TMP_Text currentDate;


    // Update is called once per frame
    void Update()
    {
        // currentTime.text = DateTime.Now.ToString(); //Date and Time
        currentDate.text = DateTime.Now.ToShortDateString(); //Time
    }
}
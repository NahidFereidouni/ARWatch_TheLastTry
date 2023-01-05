using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;



public class ScriptCurrentTime : MonoBehaviour
{
    [SerializeField] TMP_Text currentTime;


    // Update is called once per frame
    void Update()
    {
       // currentTime.text = DateTime.Now.ToString(); //Date and Time
        currentTime.text = DateTime.Now.ToShortTimeString(); //Time
    }
}

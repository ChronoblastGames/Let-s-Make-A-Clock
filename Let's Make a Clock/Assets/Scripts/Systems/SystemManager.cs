using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    [Header("System")]
    [HideInInspector]
    public DateTime systemTime;
    [HideInInspector]
    public TimeSpan systemTimeSpan;

    [Header("Season Booleans")]
    public bool isSpring;
    public bool isSummer;
    public bool isFall;
    public bool isWinter;

    private void Update()
    {
        GetSystemDateTime();
    }

    void GetSystemDateTime()
    {
        systemTime = DateTime.Now;
        systemTimeSpan = systemTime.TimeOfDay;
    }

    void ManageDate()
    {

    }

    void ManageTime()
    {

    }
}

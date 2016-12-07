﻿using System;
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

    [Header("Date")]
    public string currentDate;
    public string dayOfTheYear;

    [Header("Time")]
    public string currentTime;

    [Header("Calendar Booleans")]
    public bool isLeapYear;

    [Header("Time Of Day Booleans")]
    public bool isMorning;
    public bool isAfternoon;
    public bool isEvening;
    public bool isNight;

    [Header("Season Booleans")]
    public bool isSpring;
    public bool isSummer;
    public bool isFall;
    public bool isWinter;

    private void Update()
    {
        GetSystemDateTime();

        ManageDate();
        ManageTime();

        //Debug.Log
    }

    void GetSystemDateTime()
    {
        systemTime = DateTime.Now;
        systemTimeSpan = systemTime.TimeOfDay;
    }

    void ManageDate()
    {
        currentDate = systemTime.Date.ToShortDateString();

        if (CheckForSeason(systemTime.DayOfYear) == 1)
        {
            isSpring = false;
            isSummer = false;
            isFall = false;
            isWinter = true;
        }
        else if (CheckForSeason(systemTime.DayOfYear) == 2)
        {
            isSpring = true;
            isSummer = false;
            isFall = false;
            isWinter = false;
        }
        else if (CheckForSeason(systemTime.DayOfYear) == 3)
        {
            isSpring = false;
            isSummer = true;
            isFall = false;
            isWinter = false;
        }
        else if (CheckForSeason(systemTime.DayOfYear) == 4)
        {
            isSpring = false;
            isSummer = false;
            isFall = true;
            isWinter = false;
        }
        else
        {          
            isSpring = false;
            isSummer = false;
            isFall = false;
            isWinter = true;
        }

        dayOfTheYear = systemTime.DayOfYear.ToString();
    }

    void ManageTime()
    {
        currentTime = systemTime.ToShortTimeString();
    }

    private int CheckForSeason(int currentDayOfYear)
    {
        if (currentDayOfYear < 59) //If Before December 1 and Feb 28, return Winter;
        {
            return 1;
        }
        else if (currentDayOfYear < 151) //If Before March 1 and May 31, return Spring;
        {
            return 2;
        }
        else if (currentDayOfYear < 243) //If Between June 1 and August 31, return Summer;
        {
            return 3;
        }
        else if (currentDayOfYear < 334) //If Between September 1 and November 30, return Fall;
        {
            return 4;
        }

        else //Otherwise return Winter;
        {
            return 1;
        }
    }

    private int CheckForTimeOfDay(int currentTimeOfDay)
    {
        return 1;
    }
}

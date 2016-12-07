using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private SystemManager systemManager;

    [Header("UI Current Time")]
    public Text currentTimeText;

    [Header("UI Current Date")]
    public Text currentDateText;

	void Start ()
    {
        systemManager = GameObject.FindGameObjectWithTag("Clock").GetComponent<SystemManager>();
	}
	
	void Update ()
    {
        ManageDateText();
        ManageTimeText();
	}

    void ManageDateText()
    {
        currentDateText.text = systemManager.currentDate;
    }

    void ManageTimeText()
    {
        currentTimeText.text = systemManager.currentTime;
    }
}

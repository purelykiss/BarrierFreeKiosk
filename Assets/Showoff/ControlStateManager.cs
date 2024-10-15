using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlStateManager : MonoBehaviour
{
    public static ControlStateManager Instance;
    public enum ControlState { NONE, TOUCH, GESTURE, VOICE };
    ControlState curCtrlState;

    void Start()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);

        curCtrlState = ControlState.NONE;
    }

    public void ChangeState(int num)
    {
        if (num > 0 && num < System.Enum.GetValues(typeof(ControlState)).Length)
        {
            curCtrlState = (ControlState)num;
        }
        else
            Debug.Log("ControlStateManager.ChangeState() : Wrong input");
    }

    public ControlState GetCtrlState()
    {
        return curCtrlState;
    }
}

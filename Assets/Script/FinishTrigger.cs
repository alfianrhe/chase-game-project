using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public GameObject HalfLap;
    public GameObject LapComplete;

    private int lapCounter = 0;
    private int totalLap = 2;

    private void OnTriggerEnter()
    {
        // HalfLap.SetActive(false);
        // LapComplete.SetActive(true);

            if (lapCounter <= totalLap)
        {
            lapCounter++;
        }
            else if (lapCounter == totalLap)
        {
            HalfLap.SetActive(false);
            LapComplete.SetActive(true);
        }
    }
}

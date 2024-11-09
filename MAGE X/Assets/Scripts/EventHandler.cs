using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    private TimeMonitor timeMonitor;
    private LectureSession lectureSession;
    private TaskSession taskSession;
    private ClosingSession closingSession;
    private EndGameStats gameStats;
    private int sessionPassed;

    private void Start()
    {
        timeMonitor = GetComponent<TimeMonitor>();
        lectureSession = GetComponent<LectureSession>();
        taskSession = GetComponent<TaskSession>();
        closingSession = GetComponent<ClosingSession>();
        gameStats = GetComponent<EndGameStats>();
    }
    private void Update()
    {
        if (timeMonitor.timePassed >= 63 && sessionPassed == 0)
        {
            StartTaskSession();
        }
        if(timeMonitor.timePassed >= 180 && sessionPassed == 1)
        {
            ClosingSession();
        }
        if(timeMonitor.timePassed >= 240)
        {
            ShowGameStats();
        }
    }
    public void StartTaskSession()
    {
        taskSession.StartSession();
        sessionPassed = 1;
    }
    public void ClosingSession()
    {
        taskSession.CloseSession();
        closingSession.StartSession();
        sessionPassed = 2;
    }
    public void ShowGameStats()
    {
        //show UI game stats
        sessionPassed = 3;
    }
}

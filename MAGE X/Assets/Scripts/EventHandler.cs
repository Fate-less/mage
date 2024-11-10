using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    private FriendCallEvent friendCall;
    private GoldFishEvent goldfish;
    private PaperplaneEvent paperPlane;
    private LaughingEvent laughing;
    private TimeMonitor timeMonitor;
    private LectureSession lectureSession;
    private TaskSession taskSession;
    private ClosingSession closingSession;
    private EndGameStats gameStats;
    private int sessionPassed;
    public float eventDelayInterval = 45f;
    private float eventDelay;

    private void Start()
    {
        friendCall = GetComponent<FriendCallEvent>();
        goldfish = GetComponent<GoldFishEvent>();
        paperPlane = GetComponent<PaperplaneEvent>();
        laughing = GetComponent<LaughingEvent>();
        timeMonitor = GetComponent<TimeMonitor>();
        lectureSession = GetComponent<LectureSession>();
        taskSession = GetComponent<TaskSession>();
        closingSession = GetComponent<ClosingSession>();
        gameStats = GetComponent<EndGameStats>();
        eventDelay = eventDelayInterval;
    }
    private void Update()
    {
        eventDelay -= Time.deltaTime;
        if (eventDelay <= 0)
        {
            RandomEvent();
            eventDelay = eventDelayInterval;
        }
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
        sessionPassed = 3;
        gameStats.DisplayStats();
    }

    private void RandomEvent()
    {
        int randomValue = Random.Range(0, 3);
        if(randomValue == 0)
        {
            friendCall.StartEvent();
        }
        else if(randomValue == 1)
        {
            goldfish.StartEvent();
        }
        else if(randomValue == 2)
        {
            paperPlane.StartEvent();
        }
        else
        {
            laughing.StartEvent();
        }
    }
}

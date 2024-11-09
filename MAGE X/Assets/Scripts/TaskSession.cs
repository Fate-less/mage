using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskSession : MonoBehaviour
{
    public GameObject whiteboardTask;
    public GameObject[] taskObjects;
    public TaskAnswerCheck[] taskAnswers;
    public StareDetection stareDetection;

    private EndGameStats gameStats;

    public void Start()
    {
        gameStats = GameObject.Find("Handler").GetComponent<EndGameStats>();
    }

    public void StartSession()
    {
        whiteboardTask.SetActive(true);
        stareDetection.enabled = false;
        for(int i = 0; i < taskObjects.Length; i++)
        {
            taskObjects[i].SetActive(true);
        }
    }

    public void CloseSession()
    {
        CountCorrectAnswers();
        whiteboardTask.SetActive(false);
        for (int i = 0; i < taskObjects.Length; i++)
        {
            taskObjects[i].SetActive(false);
        }
    }

    public void CountCorrectAnswers()
    {
        for (int i = 0; i < taskAnswers.Length; i++)
        {
            if (taskAnswers[i].correctAnswer)
            {
                gameStats.taskCompletion++;
            }
        }
    }
}

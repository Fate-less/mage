using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskAnswerCheck : MonoBehaviour
{
    public string answer;
    public bool correctAnswer;
    private EndGameStats gameStats;

    private void Start()
    {
        gameStats = GameObject.Find("Handler").GetComponent<EndGameStats>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Task"))
        {
            if(other.gameObject.name == answer)
            {
                correctAnswer = true;
            }
            else
            {
                correctAnswer = false;
            }
        }
    }
}

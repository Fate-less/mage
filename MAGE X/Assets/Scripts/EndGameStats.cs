using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameStats : MonoBehaviour
{
    public float attention;
    public float taskCompletion;

    private float attentionPercentage;
    private float taskCompletePercentage;

    public void CountAttentionPercentage()
    {
        attentionPercentage = attention / 120 * 100;
    }

    public void CountTaskCompletePercentage()
    {
        taskCompletePercentage = taskCompletion / 6 * 100;
    }

    public float DisplayAttentionPercentage()
    {
        return attentionPercentage;
    }
    public float DisplayTaskCompletePercentage()
    {
        return taskCompletePercentage;
    }
}

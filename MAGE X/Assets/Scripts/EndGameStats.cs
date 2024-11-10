using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndGameStats : MonoBehaviour
{
    public float attention;
    public float taskCompletion;
    public GameObject endGameStatsObject;
    public TextMeshProUGUI overallStatsText;
    public TextMeshProUGUI attentionText;
    public TextMeshProUGUI taskCompletionText;

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

    public void DisplayStats()
    {
        endGameStatsObject.SetActive(true);
        if(attentionPercentage == 100)
        {
            overallStatsText.text = "Fokus sempurna! Kamu tidak melewatkan satu pun detail dari pelajaran hari ini.";
        }
        else if(attentionPercentage > 80)
        {
            overallStatsText.text = "Luar biasa! Kamu sangat fokus dan berhasil mengikuti penjelasan dengan baik.";
        }
        else if (attentionPercentage > 60)
        {
            overallStatsText.text = "Kamu cukup perhatian! Sebagian besar materi berhasil kamu ikuti dengan baik.";
        }
        else if (attentionPercentage > 40)
        {
            overallStatsText.text = "Kamu sempat mendengarkan, meskipun fokusmu belum sepenuhnya terjaga";
        }
        else if (attentionPercentage > 20)
        {
            overallStatsText.text = "Sedikit perhatian, tapi masih sering teralihkan oleh sekitarmu.";
        }
        else
        {
            overallStatsText.text = "Sulit fokus, ya? Mungkin banyak gangguan yang mengalihkan perhatianmu";
        }
        attentionText.text = "Attention to Lecture : " + attentionPercentage.ToString() + "%";
        taskCompletionText.text = "Task Completion : " + taskCompletePercentage.ToString() + "%";
        StartCoroutine(countDown());
    }

    IEnumerator countDown()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Mainmenu");
    }
}

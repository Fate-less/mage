using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StareDetection : MonoBehaviour
{
    public GameObject playerCamera;
    public EndGameStats gameStats;

    private void Start()
    {
        gameStats = GameObject.Find("Handler").GetComponent<EndGameStats>();
    }

    void Update()
    {
        Vector3 playerToTarget = transform.position - playerCamera.transform.position;
        float angle = Vector3.Angle(playerCamera.transform.forward, playerToTarget);

        if (angle < 30f)
        {
            gameStats.attention += Time.deltaTime;
        }
    }
}

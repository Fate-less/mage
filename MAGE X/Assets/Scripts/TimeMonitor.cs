using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMonitor : MonoBehaviour
{
    public float timePassed;

    private void Update()
    {
        timePassed += Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeChanges : MonoBehaviour
{
    public float startingVolume = 0.2f;
    public float volumeIncrease = 0.01f;
    public float volumeIncreaseInterval = 3;
    public AudioSource[] audioSources;
    private float countDown;

    private void Start()
    {
        countDown = volumeIncreaseInterval;
    }
    private void Update()
    {
        countDown -= Time.deltaTime;
        if(countDown <= 0)
        {
            AdjustVolume();
            countDown = volumeIncreaseInterval;
        }
    }

    public void AdjustVolume()
    {
        for(int i = 0; i < audioSources.Length; i++)
        {
            audioSources[i].volume += volumeIncrease;
        }
        //Debug.Log("Volume Adjusted");
    }
}

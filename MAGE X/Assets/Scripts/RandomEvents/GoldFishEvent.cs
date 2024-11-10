using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldFishEvent : MonoBehaviour
{
    public AudioSource sfx;

    public void StartEvent()
    {
        sfx.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendCallEvent : MonoBehaviour
{
    public AudioSource sfx;

    public void StartEvent()
    {
        sfx.Play();
    }
}

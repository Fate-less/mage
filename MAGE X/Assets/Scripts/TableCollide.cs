using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableCollide : MonoBehaviour
{
    public AudioClip tableSFX;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            AudioSource.PlayClipAtPoint(tableSFX, gameObject.transform.position);
        }
    }
}

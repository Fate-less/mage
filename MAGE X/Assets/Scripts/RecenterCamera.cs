using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecenterCamera : MonoBehaviour
{
    public Transform head;
    public Transform origin;
    public Transform target;

    public void Recenter()
    {
        Vector3 offset = head.position - origin.position;
        offset.y = 0;
        origin.position = target.position - offset;

        Vector3 targetForward = target.forward;
        targetForward.y = 0f;
        Vector3 cameraForward = head.forward;
        cameraForward.y = 0f;

        float angle = Vector3.SignedAngle(cameraForward, targetForward, Vector3.up);
        origin.RotateAround(head.position, Vector3.up, angle);
    }

    private void Start()
    {
        StartCoroutine(delayOneFrame());
    }

    IEnumerator delayOneFrame()
    {
        yield return new WaitForSeconds(0.2f);
        Recenter();
    }
}

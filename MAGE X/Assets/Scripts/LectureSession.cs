using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LectureSession : MonoBehaviour
{
    public WriterEffect lectureScript;
    public StareDetection stareDetection;

    private void Start()
    {
        stareDetection.enabled = true;
        lectureScript.StartTyping();
    }
}

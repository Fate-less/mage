using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LectureSession : MonoBehaviour
{
    public WriterEffect lectureScript;

    private void Start()
    {
        lectureScript.StartTyping();
    }
}

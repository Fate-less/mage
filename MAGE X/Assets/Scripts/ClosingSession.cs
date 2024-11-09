using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingSession : MonoBehaviour
{
    public WriterEffect closingScript;
    public StareDetection stareDetection;

    public void StartSession()
    {
        stareDetection.enabled = true;
        closingScript.StartTyping();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingSession : MonoBehaviour
{
    public WriterEffect closingScript;

    public void StartSession()
    {
        closingScript.StartTyping();
    }
}

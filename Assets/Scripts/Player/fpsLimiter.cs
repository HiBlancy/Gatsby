using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsLimiter : MonoBehaviour
{
    void Awake ()
    {
        Application.targetFrameRate = 60;
    }
}

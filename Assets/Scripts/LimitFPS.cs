using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitFPS : MonoBehaviour
{
    // Start is called before the first frame update
    public int frameRate = 30;
    void Start()
    {
        Application.targetFrameRate = frameRate;
    }

}

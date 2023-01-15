using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowFPS : MonoBehaviour
{
    public float timer, refresh, avgFrameRate;
    public TextMeshProUGUI fpsText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float timeLapse = Time.smoothDeltaTime;
        timer = timer <= 0 ? refresh : timer -= timeLapse;

        if (timer <= 0) avgFrameRate = (int)(1f / timeLapse);
        fpsText.text = avgFrameRate.ToString();
    }
}

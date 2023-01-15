using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayAndShow : MonoBehaviour
{
    public float delay;
    public bool isLoadingAPage;
    public void DelayThenShow()
    {
        Invoke("Show", delay);
    }
    private void Show()
    {
        gameObject.SetActive(true);
    }
}

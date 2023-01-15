using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayAndHide : MonoBehaviour
{
    public float delay;
    public void DelayThenHide()
    {
        Invoke("Hide", delay);
    }
    private void Hide()
    {
        gameObject.SetActive(false);
    }
}

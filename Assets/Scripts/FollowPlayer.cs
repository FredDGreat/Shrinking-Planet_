using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    public float smoothSpeed = 0.04f;
    // Start is called before the first frame update
    void Start()
    {
        //offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 newPosition = target.position + offset;
        //Vector3 newPosition = Vector3.Lerp(transform.position, target.position + offset, smoothSpeed);
        //transform.position = newPosition;
    }
}

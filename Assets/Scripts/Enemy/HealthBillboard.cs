using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBillboard : MonoBehaviour
{
    private Transform Cam;

    private void Start()
    {
        Cam = GameObject.Find("Main Camera").transform;
    }
    private void LateUpdate()
    {
        transform.LookAt(transform.position + Cam.forward);
    }
}

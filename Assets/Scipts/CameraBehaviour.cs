using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Vector3 CamOffset = new Vector3(0f, 1.2f, -2.6f);

    private Transform target;
  
    void Start()
    {
        target = GameObject.Find("Personaje").transform;
    }

  
    void LateUpdate()
    {
        this.transform.position = target.TransformPoint(CamOffset);
        this.transform.LookAt(target);
    }
}

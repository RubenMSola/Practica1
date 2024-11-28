using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaDesaparicion : MonoBehaviour
{
    public float OnscreenDelay = 3f;
    void Start()
    {
        Destroy (this.gameObject,OnscreenDelay);
    }

}

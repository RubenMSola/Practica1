using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaDesaparicion : MonoBehaviour
{

    //Crea un delay para que desaparezca la bala al cabo de un tiempo

    public float OnscreenDelay = 3f;

    void Start()
    {
        Destroy (this.gameObject,OnscreenDelay);
    }

}

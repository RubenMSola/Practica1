using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Personaje")
        {
            print("Personaje Detectado");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Personaje")
        {
            print("Personaje Salio");
        }
    }
}

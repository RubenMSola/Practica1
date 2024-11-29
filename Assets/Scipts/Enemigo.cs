using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) //Creamos un metodo para que detecte la collision trigger de un objeto y si interactua con otro objeto "Personaje" que pase algo "lo muestre en la comsola"
    {
        if(other.name == "Personaje")
        {
            print("Personaje Detectado");
        }
    }

    private void OnTriggerExit(Collider other) // lo mismo que el codigo anterior pero al salir del trigger
    {
        if (other.name == "Personaje")
        {
            print("Personaje Salio");
        }
    }
}

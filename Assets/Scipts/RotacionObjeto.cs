using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionObjeto : MonoBehaviour
{
    
    public int rotationSpeed = 100; //Variable que indica la velocidad de rotacion
    private Transform itemTransform; //Variable que indica la "transform" del objeto


    void Start()
    {
        itemTransform = this.GetComponent<Transform>(); //Indicamos que nuestra variable "transform" es equivalente a la "transform" en el editor del objeto en el que esté este codigo
    }


    void Update()
    {
        itemTransform.Rotate(rotationSpeed * Time.deltaTime,0,0); 
        //Indicamos que el objeto rote en su eje x según nuestra variable de rotacion y le añadimos "Time.deltaTime" para que rote segun los segundos y no dependa de los frames de la pantalla
    }
}

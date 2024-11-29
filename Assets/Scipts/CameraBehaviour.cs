using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    //Variables paara definir la camara y su posicion
    public Vector3 CamOffset = new Vector3(0f, 1.2f, -2.6f);
    private Transform target;
  
    void Start() //Nada mas empezar el juego detecta al personaje y lo empezara a seguir
    {
        target = GameObject.Find("Personaje").transform;
    }

  
    void LateUpdate() //Metodo parta que se actualice la posicion de la camara cada frame
    {
        this.transform.position = target.TransformPoint(CamOffset);
        this.transform.LookAt(target);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //Le damos acceso al script de GameBehaviour
    public GameBehaviour gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehaviour>();
    }
    private void OnCollisionEnter(Collision collision) //Creamos un metodo para que detecte la colision del personaje, despues te du un punto y se destruya
    {
        if (collision.gameObject.name == "Personaje")
        {
            Destroy(this.transform.parent.gameObject);
            print("Recogido");

            gameManager.Items += 1;
        }
    }
}

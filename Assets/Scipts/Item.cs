using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Personaje")
        {
            Destroy(this.transform.parent.gameObject);
            print("Recogido");
        }
    }
}
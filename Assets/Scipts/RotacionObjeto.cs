using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionObjeto : MonoBehaviour
{

    public int rotationSpeed = 100;
    private Transform itemTransform;

    // Start is called before the first frame update
    void Start()
    {
        itemTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        itemTransform.Rotate(rotationSpeed * Time.deltaTime,0,0);
    }
}

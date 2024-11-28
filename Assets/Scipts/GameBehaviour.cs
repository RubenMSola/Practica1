using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    private int itemsCollected = 0;
    private int PersonajeHP = 100;

    public int Items
    {
        get { return itemsCollected; }
        set { itemsCollected = value; Debug.LogFormat("Items: {0}", itemsCollected);}
    }
    public int HP
    {
        get { return PersonajeHP; }
        set { PersonajeHP = value; Debug.LogFormat("Lives: {0}", PersonajeHP);}
    }
}

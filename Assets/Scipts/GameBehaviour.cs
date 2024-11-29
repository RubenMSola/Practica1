using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBehaviour : MonoBehaviour
{
    //Variables internos para la UI
    private int itemsCollected = 0;
    public int MaxItems = 4;
    private int personajeHP = 100;
    public Button winButton;
    
    //Variables para almacenar los textos de sobre la informacion del personaje
    public TMP_Text healthText;
    public TMP_Text itemText;
    public TMP_Text progressText;

    void Start() 
    {
        itemText.text += itemsCollected;
        healthText.text += personajeHP;
    }   

    public int Items
    {
        get { return itemsCollected; }
        set 
        { itemsCollected = value; 
          itemText.text = "Item Collected: " + Items;

          if (itemsCollected >= MaxItems)
          {
            progressText.text = "You have found all items";
                winButton.gameObject.SetActive(true);
                Time.timeScale = 0f;
          }
          else
          {
            progressText.text = "Item found, only " + (MaxItems - itemsCollected) + " more";
          }
        }
    }
    public int HP
    {
        get { return personajeHP; }
        set 
        { personajeHP = value; 
          healthText.text = "Player Health: " + HP; 
          Debug.LogFormat("Lives: {0}", personajeHP);
        }
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}

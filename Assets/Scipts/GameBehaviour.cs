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

    public Button lossButton;


    void Start() 
    {
        itemText.text += itemsCollected;
        healthText.text += personajeHP;
    }   
    public void UpdateScene(string updateText)
    { 
        progressText.text = updateText;
        Time.timeScale = 0f;

    }

    public int Items
    {
        get { return itemsCollected; }
        set 
        { itemsCollected = value; 
          itemText.text = "Item Collected: " + Items;

          if (itemsCollected >= MaxItems)
          {
                winButton.gameObject.SetActive(true);
                UpdateScene("You have all the items");
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
          if (personajeHP <= 0)
            {
                lossButton.gameObject.SetActive(true);
                UpdateScene("You want another life with that");
            }
          else
            {
                progressText.text = "Ouch";
            }
        }
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}

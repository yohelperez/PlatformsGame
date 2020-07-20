﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    public Text text; //texto "presionar e para entrar"
    private bool inDoor = false; //verifica que el player este en una puerta

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            text.gameObject.SetActive(true);
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        text.gameObject.SetActive(false);
        inDoor = false;

    }
    private void Update()
    {
        if (inDoor && Input.GetKey("e"))
        {
            
        }
        
    }
}

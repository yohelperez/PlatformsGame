using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollected : MonoBehaviour
{
    //verifica que cuando haya una colision y sea con el jugador se muestre la animación y se elimine la fruta
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false; //desactiva renderización de la fruta
            gameObject.transform.GetChild(0).gameObject.SetActive(true); //activa el hijo del gameobject fruit que es la animacion collected
            Destroy(gameObject, 0.5f);  //destruye la fruta y todo lo que tiene
        }
    }
}

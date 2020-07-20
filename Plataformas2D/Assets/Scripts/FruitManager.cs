using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //para el cambio de escena
using UnityEngine.UI; //para el uso del texto al finalizar un nivel

public class FruitManager : MonoBehaviour
{
    public Text levelCleared; //texto de All fruits collected

    //para el conteo de frutas
    public Text totalFruits;
    public Text collectedFruits;
    private int totalFruitsInLevel;


    private void Start()
    {
        totalFruitsInLevel = transform.childCount; 
    }

    private void Update()
    {
        AllFruitsCollected(); //llama la funcion para verificar en cada frame cuantas frutas quedan
        totalFruits.text = totalFruitsInLevel.ToString(); //muestra el numero total de frutas en el nivel
        collectedFruits.text = (totalFruitsInLevel - transform.childCount).ToString(); //muestra el numero de frutas cogidas
    }

    //cuenta el numero de frutas que hay y comprueba que solo quede una
    public void AllFruitsCollected()
    {
        if (transform.childCount==0)
        {
            Debug.Log("No fruits left");
            levelCleared.gameObject.SetActive(true);
            Invoke("ChangeScene", 1); //invoca al metodo para cambiar de escena despues de 1 segundo
        }
    }

    //metodo para cambiar de escena
    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //carga la escena siguiente 
    }
}

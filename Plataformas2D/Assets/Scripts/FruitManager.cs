using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //para el cambio de escena
using UnityEngine.UI; //para el uso del texto al finalizar un nivel

public class FruitManager : MonoBehaviour
{
    public Text levelCleared; //texto de All fruits collected

    private void Update()
    {
        AllFruitsCollected(); //llama la funcion para verificar en cada frame cuantas frutas quedan
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

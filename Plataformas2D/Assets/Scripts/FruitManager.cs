using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    //cuenta el numero de frutas que hay y comprueba que solo quede una
   public void AllFruitsCollected()
    {
        if (transform.childCount==1)
        {
            Debug.Log("No fruits left");
        }
    }
}

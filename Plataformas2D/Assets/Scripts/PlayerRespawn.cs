using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerRespawn : MonoBehaviour
{
    public Animator animator; //referencia a la animacion

    public void PlayerDamaged()
    {
        animator.Play("Hit"); //activa la animacion
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //recarga la escena
    }
}

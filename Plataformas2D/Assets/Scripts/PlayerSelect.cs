using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public enum Player {Frog, VirtualGuy, PinkMan }; //crea una lista de los skins habilitados
    public Player playerSelected; //skin seleccionado

    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public RuntimeAnimatorController[] playersController; //arrreglo de animaciones: hace referencia al arbol de animaciones
    public Sprite[] playersRenderer; //arreglo de los sprites

    // Start is called before the first frame update
    void Start()
    {
        switch (playerSelected)
        {
            case Player.Frog:
                spriteRenderer.sprite = playersRenderer[0]; //carga el sprite Idle del personaje seleccionado
                animator.runtimeAnimatorController = playersController[0]; //carga el controller del nuevo personaje
                break;
            case Player.PinkMan:
                spriteRenderer.sprite = playersRenderer[1]; //carga el sprite Idle del personaje seleccionado
                animator.runtimeAnimatorController = playersController[1]; //carga el controller del nuevo personaje
                break;
            case Player.VirtualGuy:
                spriteRenderer.sprite = playersRenderer[2]; //carga el sprite Idle del personaje seleccionado
                animator.runtimeAnimatorController = playersController[2]; //carga el controller del nuevo personaje
                break;
            default:
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool isGrounded;

    //Cuando el boxCollider2D entre dentro de una geometria
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
    }

    //Cuando el boxCollider2D salga de una geometria
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }
}

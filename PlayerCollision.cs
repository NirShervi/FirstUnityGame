using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "bullet(Clone)")
        {
            Destroy(collision.gameObject);
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

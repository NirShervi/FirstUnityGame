using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(Collider col)
    { 
        if(col.gameObject.name == "Person")
        {
            gameManager.GameWon();
        }
        
    }
}

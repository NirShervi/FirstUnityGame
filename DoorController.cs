using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject Door;
    public bool doorIsOpening;
    bool playerIsHere;
    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
        doorIsOpening = false;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FindObjectOfType<GameManager>().ExitGame();
        }

        if (Input.GetKeyDown(KeyCode.F1))
        {
            FindObjectOfType<GameManager>().RestartGame();
        }

        if (playerIsHere)
        {
            if (Door.transform.position.y < 20f)
            {
                Door.transform.Translate(Vector3.up * Time.deltaTime * 5);
            }
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerIsHere = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerIsHere = false;
        }
    }
}

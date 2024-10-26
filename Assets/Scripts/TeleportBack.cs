using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportBack : MonoBehaviour
{
    public string levelname;
    private bool onDoormat = false;
    private GameObject teleportback;
    private GameObject player;

    Vector3 offsetVector;

    void OnTriggerEnter(Collider other)
    {
        //if (Input.GetKeyDown("e"))
        //{
        //    SceneManager.LoadScene(levelname);
        //}
        onDoormat = true;
    }
    private void OnTriggerExit(Collider other)
    {
        onDoormat = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown("e") && onDoormat)
        {
            SceneManager.LoadScene(levelname);
            teleportback = GameObject.FindWithTag("TeleportBack");
            player = GameObject.FindWithTag("Player");
            player.transform.position = teleportback.transform.position;
        }
    }
}

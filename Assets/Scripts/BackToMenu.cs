using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenu : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger event: " + other.gameObject);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }
}

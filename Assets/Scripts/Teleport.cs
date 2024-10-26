using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Teleport : MonoBehaviour
{
    public string levelname;
    private bool onDoormat = false;
    public TextMeshProUGUI controlText;

    Vector3 offsetVector;
    private void Start()
    {
        controlText.text = "";
    }
    void OnTriggerEnter(Collider other)
    {
        onDoormat = true;
        controlText.text = "Press E";
    }
    private void OnTriggerExit(Collider other)
    {
        onDoormat = false;
        controlText.text = "";
    }
    private void Update()
    {
        if (Input.GetKeyDown("e") && onDoormat)
        {
            SceneManager.LoadScene(levelname);
        }
    }
}

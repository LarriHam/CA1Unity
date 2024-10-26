using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collectable : MonoBehaviour
{

    public static Action OnMushCollected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(OnMushCollected != null) OnMushCollected();

            Destroy(gameObject);
        }
    }
}

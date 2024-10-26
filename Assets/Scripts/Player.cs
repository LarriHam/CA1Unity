using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _mushrooms;
    public int Mushrooms { get => _mushrooms; }

    private void MushCollected()
    {
        //Debug.Log(Mushrooms);
        _mushrooms++;
    }

    void Start()
    {
        Collectable.OnMushCollected += MushCollected;
    }

    private void OnDestroy()
    {
        Collectable.OnMushCollected -= MushCollected;
    }
}

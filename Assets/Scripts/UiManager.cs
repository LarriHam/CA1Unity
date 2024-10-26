using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{


    [SerializeField]
    private TextMeshProUGUI _mushTxt;

    [SerializeField]
    private Player _playerRef;

    private void AddMush()
    {
        //Debug.Log(_playerRef.Mushrooms);
        _mushTxt.text = "Mushrooms: " + _playerRef.Mushrooms;
        //(_playerRef.Mushrooms + 1)
    }

    void Start()
    {
        Collectable.OnMushCollected += AddMush;
    }

    private void OnDestroy()
    {
        Collectable.OnMushCollected -= AddMush;
    }

}

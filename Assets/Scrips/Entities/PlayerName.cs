using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public TMP_Text playerName;

    private void Start()
    {
        playerName.text = PlayerPrefs.GetString("PlayerName");
        Debug.Log(playerName.text);
    }

}

using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetPlayerInfo : MonoBehaviour
{
    public void GetInfo(GameObject Peng)
    {
        if (Peng.activeSelf) 
            PlayerPrefs.SetString("PlayerChar", "Peng");
        else
            PlayerPrefs.SetString("PlayerChar", "Cat");
    }
}

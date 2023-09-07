using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetNetInfo : MonoBehaviour
{
    public void ReNaming(TMP_InputField InputName)
    {
        string playerName = InputName.GetComponent<TMP_InputField>().text;

        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            PlayerPrefs.SetString("PlayerName", playerName);
        }
    }

    public void CharacterChanging(GameObject Peng)
    {
        if (Peng.activeSelf)
            PlayerPrefs.SetString("PlayerChar", "Peng");
        else
            PlayerPrefs.SetString("PlayerChar", "Cat");
    }
}

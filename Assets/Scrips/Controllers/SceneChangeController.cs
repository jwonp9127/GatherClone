using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChangeController : MonoBehaviour
{
    public void SceneChange(TMP_InputField InputName)
    {
        string playerName = InputName.GetComponent<TMP_InputField>().text;

        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            PlayerPrefs.SetString("PlayerName", playerName);
            SceneManager.LoadScene("MainScene");
        }
    }

    public void Intro()
    {
        SceneManager.LoadScene("GetNameScene");
    }
}

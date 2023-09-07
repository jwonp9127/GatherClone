using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GetParticipantsList : MonoBehaviour
{
    public TMP_Text List;
    private List<string> list = new List<string>();

    private void Start()
    {
    }

    void Update()
    {
        ReLoadNameList();

        List.text = "";
        foreach(var item in list)
        {
            List.text += item + '\n';
        }

    }

    private void ReLoadNameList()
    {
        list.Clear();
        list.Add(PlayerPrefs.GetString("PlayerName"));
        list.Add("¿°¿¹Âù Æ©ÅÍ´Ô");
    }
}

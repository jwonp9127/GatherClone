using System.Collections;
using System.Collections.Generic;
using System.Data;
using System;
using UnityEngine;
using TMPro;

public class GetTime : MonoBehaviour
{
    public TMP_Text time;

    void Update()
    {
        time.text = UpdateTime();
    }

    public string UpdateTime()
    {
        return DateTime.Now.ToString("yyyy/MM/dd tt h:mm");
    }
}

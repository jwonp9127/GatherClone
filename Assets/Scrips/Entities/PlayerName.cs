using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
enum Characters
{
    Peng = 0,
    Cat = 1
}

public class PlayerName : MonoBehaviour
{
    public TMP_Text playerName;
    private string playerChar;
    public GameObject Peng;
    public GameObject Cat;
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();

    }
    private void Start()
    {
        playerName.text = PlayerPrefs.GetString("PlayerName");
        playerChar = PlayerPrefs.GetString("PlayerChar");

        if (playerChar == "Peng")
        {
            Peng.SetActive(true);
            Cat.SetActive(false);
            animator.SetInteger("Character", (int)(Characters.Peng));
        }
        else
        {
            Peng.SetActive(false);
            Cat.SetActive(true);
            animator.SetInteger("Character", (int)(Characters.Cat));
        }
    }

    private void Update()
    {
        playerName.text = PlayerPrefs.GetString("PlayerName");
        playerChar = PlayerPrefs.GetString("PlayerChar");

        if (playerChar == "Peng")
        {
            Peng.SetActive(true);
            Cat.SetActive(false);
            animator.SetInteger("Character", (int)(Characters.Peng));
        }
        else
        {
            Peng.SetActive(false);
            Cat.SetActive(true);
            animator.SetInteger("Character", (int)(Characters.Cat));
        }
    }

}

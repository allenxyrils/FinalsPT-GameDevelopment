using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_Text hcoinFIELD;
    int hcoins;

    // Start is called before the first frame update
    void Start()
    {
        hcoins = PlayerPrefs.GetInt("Hcoins");
        hcoinFIELD.text = hcoins.ToString();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene("Scene");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CurrentScore : MonoBehaviour
{
    public Text ccoinFIELD;
    public Text ccoin2FIELD;
    public Text hcoinFIELD;
    public Text hcoin2FIELD;
    public Text hcoin3FIELD;
    public int ccoins;
    public int hcoins;
    public GameObject fpanel;
    public GameObject spanel;
    public GameObject mpanel;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Ccoins", 0);
        hcoins = PlayerPrefs.GetInt("Hcoins");
    }
    // Update is called once per frame
    void Update()
    {
        ccoins = PlayerPrefs.GetInt("Ccoins");
        ccoinFIELD.text = ccoins.ToString();
        hcoinFIELD.text = hcoins.ToString();
    }

    public void overAllScore()
    {
        if (ccoins > hcoins)
        {
            hcoins = ccoins;
            PlayerPrefs.SetInt("Hcoins", ccoins);
            spanel.SetActive(true);
            mpanel.SetActive(false);
            hcoin2FIELD.text = hcoins.ToString();
        }
        else
        {
            PlayerPrefs.SetInt("Hcoins", hcoins);
            fpanel.SetActive(true);
            mpanel.SetActive(false);
            hcoin3FIELD.text = hcoins.ToString();
            ccoin2FIELD.text = ccoins.ToString();
        }
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MoveToScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}

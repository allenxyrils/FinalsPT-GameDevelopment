using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPlayerprefs : MonoBehaviour
{
    public int ccoins;
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        ccoins = PlayerPrefs.GetInt("Ccoins");
    }
    void Update()
    {
        ccoins = PlayerPrefs.GetInt("Ccoins");
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            sound.Play();
            ccoins = ccoins + 1;

            Destroy(gameObject);
            PlayerPrefs.SetInt("Ccoins", ccoins);
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject startpanel;
    public GameObject ongoingpanel;
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 1f;
            startpanel.SetActive(false);
            ongoingpanel.SetActive(true);
            sound.Play();
        }
    }
}

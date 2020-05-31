using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D playerRB;
    public AudioSource backgroundSound;

    void Start()
    {
        Time.timeScale = 0;
    }


    void Update()
    {
        
    }

    public void OnClick(string value)
    {
        if(value == "start")
        {
            Time.timeScale = 1;
            gameObject.transform.position = new Vector3(-1000f, 0f, 0f);
        }
        else if (value == "retry")
        {
            SceneManager.LoadScene(0);
        }
        else if (value == "music")
        {
            if (backgroundSound.mute == true)
                backgroundSound.mute = false;
            else if (backgroundSound.mute == false)
                backgroundSound.mute = true;
        }
        else if (value == "quit")
        {
            Application.Quit();
        }
        else
        {

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float jumpPower;
    public Rigidbody2D rigidbody;
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textPlay;
    public GameObject menu;
    public Button buttonStart;
    public Button buttonRetry;
    Vector3 menuOldPos;
    Vector3 buttonStartPos;
    int score;

    private void Start()
    {
        score = 0;
        menuOldPos = menu.transform.position;
        buttonStartPos = buttonStart.transform.position;
    }

    void Update()
    {
        textScore.SetText(score.ToString());
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(new Vector3(0f,jumpPower,0f));
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Score"))
        {
            score += 10;
        }
        else if (collision.CompareTag("Obsticle"))
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Time.timeScale = 0;
        menu.transform.position = menuOldPos;
        buttonStart.transform.position = new Vector3(-1000f,0f,0f);
        buttonRetry.transform.position = buttonStartPos;
    }

}

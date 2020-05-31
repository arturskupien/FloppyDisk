using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float jumpPower;
    public Rigidbody2D rigidbody;
    public TextMeshProUGUI textScore;
    int score;

    private void Start()
    {
        score = 0;
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
            //Debug.Log("Added Score");
        }
        else if (collision.CompareTag("Obsticle"))
        {
            //Debug.Log("Game Over");
            Time.timeScale = 0;
        }
        else if (collision)
        {

        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    float randNum;
    float randPosition;

    private void Update()
    {
        randNum = Random.Range(-1f,1f);
        randPosition = Random.Range(-1.5f,1.5f) + randNum;
    }

    void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(200f * Time.deltaTime, 0f, 0f);
        //Debug.Log(rigidbody.velocity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleport"))
        {
            gameObject.transform.position = new Vector3(-15f, randPosition, 0f);
        }
    }
}

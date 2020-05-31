using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public Collider2D playerCollider;

    void Update()
    {
        rigidbody.AddForce(new Vector3(0.5f,0f,0f));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Score"))
        {
            //score++ or some shit
        }
        else if(collision.CompareTag("Obsticle"))
        {
            //GameOver
        }
    }

}

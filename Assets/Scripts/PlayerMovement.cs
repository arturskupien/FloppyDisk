using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    [SerializeField] float jumpPower;

    void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(new Vector3(0f,jumpPower,0f));

            Debug.Log("Done");
        }
    }
}

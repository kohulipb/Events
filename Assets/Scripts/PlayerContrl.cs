using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContrl : MonoBehaviour
{
    [SerializeField] float playerSpeed = 5;
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f, playerSpeed * Time.deltaTime, 0f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0f, -1 * playerSpeed * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(playerSpeed * Time.deltaTime, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-playerSpeed * Time.deltaTime, 0f, 0f);
        }
    }
}

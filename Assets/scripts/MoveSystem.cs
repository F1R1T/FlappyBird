using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{

    void Jump ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(1.5f, 0f);
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200);
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

}

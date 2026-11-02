using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletScript : MonoBehaviour
{
    public Transform T;
    public Rigidbody2D RB1;
    public Rigidbody2D RB2;
    public GameObject Bullet;
    public float BulletSpeed = 10f;

    //The player calls this function on the coin whenever they bump into it

    void Update()
    {
        if (T.position.x < -12f)
        {
            Destroy(gameObject);
        }

        if (T.position.x > 12f)
        {
            Destroy(gameObject);
        }

        RB1 = GetComponent<Rigidbody2D>();

        RB1.linearVelocity = transform.right * BulletSpeed;

        RB2 = GetComponent<Rigidbody2D>();

        RB2.linearVelocity = transform.right * -BulletSpeed;
    }
    public void

    GetBumped()
    {
        //This destroys the object
        Destroy(gameObject);

    }

    //This is done for ease of coding, not because effecient
    //Am sorry for stealing
}

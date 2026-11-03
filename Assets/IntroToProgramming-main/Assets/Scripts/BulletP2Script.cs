using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletP2Script : MonoBehaviour
{
    public Transform T2;
    public Rigidbody2D RB2;
    public GameObject Bullet;
    public float BulletSpeed2 = 10f;

    //The player calls this function on the coin whenever they bump into it

    void Update()
    {
        if (T2.position.x < -12f)
        {
            Destroy(gameObject);
        }

        if (T2.position.x > 12f)
        {
            Destroy(gameObject);
        }

        Vector2 vel = new Vector2(-10, 0);

        RB2.linearVelocity = vel;

    }
    public void

    GetBumped2()
    {
        //This destroys the object
        Destroy(gameObject);

    }

    //This is done for ease of coding, not because effecient
    //Am sorry for stealing
}

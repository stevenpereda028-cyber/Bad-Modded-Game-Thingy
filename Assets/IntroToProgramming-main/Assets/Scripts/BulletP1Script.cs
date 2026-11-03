using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletP1Script : MonoBehaviour
{
    public Transform T1;
    public Rigidbody2D RB1;
    public GameObject Bullet;
    public float BulletSpeed1 = 10f;

    //The player calls this function on the coin whenever they bump into it

    void Update()
    {
        if (T1.position.x < -12f)
        {
            Destroy(gameObject);
        }

        if (T1.position.x > 12f)
        {
            Destroy(gameObject);
        }

        Vector2 vel = new Vector2(10, 0);

        RB1.linearVelocity = vel;

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

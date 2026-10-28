using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Transform T;
    //The player calls this function on the coin whenever they bump into it

    private void Update()
    {
        if (T.position.x < -12f)
        {
            Destroy(gameObject);
        }

        if (T.position.x > 12f)
        {
            Destroy(gameObject);
        }

    }
    public void GetBumped()
    {
        //This destroys the object
        Destroy(gameObject);
    }
    //This is done for ease of coding, not because effecient
    //Am sorry for stealing
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{   
    public void GetBumped()
    {
        //This destroys the coin
        Destroy(gameObject);
    }

}

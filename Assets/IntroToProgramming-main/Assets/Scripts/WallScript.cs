using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using Vector3 = UnityEngine.Vector3;

public class WallScript : MonoBehaviour
{
    public Rigidbody2D RB;
    public Transform T;
    public float Speed = 6;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     //Leave blank
    }
    void Update()
    {  
        //Wall movement
        Vector3 vel = new Vector3(0,0,0);
        {
            vel.y = -Speed;
        }
        
        RB.linearVelocity = vel;

        if (T.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        BulletScript Hazard = other.gameObject.GetComponent<BulletScript>();
        if (Hazard != null)
        {
            //Send message back that contact was made
            Hazard.GetBumped();
        }

        //This checks to see if the thing you bumped into has the CoinScript script on it
        CoinScript coin = other.gameObject.GetComponent<CoinScript>();
        //If it does, run the code block belows
        if (coin != null)
        {
            //Tell the coin that you bumped into them so they can self destruct or whatever
            coin.GetBumped();
        }
    }

}

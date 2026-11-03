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
        BulletP1Script Hazard1 = other.gameObject.GetComponent<BulletP1Script>();
        if (Hazard1 != null)
        {
            //Send message back that contact was made
            Hazard1.GetBumped2();
        }

        BulletP2Script Hazard2 = other.gameObject.GetComponent<BulletP2Script>();
        if (Hazard2 != null)
        {
            //Send message back that contact was made
            Hazard2.GetBumped2();
        }

    }

}

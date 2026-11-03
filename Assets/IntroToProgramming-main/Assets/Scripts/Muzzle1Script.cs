using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Muzzle1Script : MonoBehaviour
{
    public Transform FiringPoint;
    public GameObject Bullet;
    public float Cooldown;
    public float CooldownReference;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cooldown -= Time.deltaTime;
        if (Cooldown <= 0f && Keyboard.current.eKey.isPressed)
        {
            Shoot1();
            Cooldown = CooldownReference;
        }

    }

    void Shoot1()
    {
        Instantiate(Bullet, FiringPoint.position, FiringPoint.rotation);
    }
   
}

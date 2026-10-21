using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class WallSpawnerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float Delay;
    public float DelayReference;
    public GameObject SpawnedObject;
    public Vector2 Range;

    void Update()
    {
        Delay -= Time.deltaTime;
        //If Countdown hits 0, that means it's time to spawn the new object
        if (Delay <= 0f)
        {
            Delay = DelayReference;
;
            //First we decide where the object should spawn.
            //We take the spawner's position (transform.position) and offset it by the random spawn range
            Vector3 where = transform.position + new Vector3(Random.Range(-Range.x, Range.x),
                Random.Range(-Range.y, Range.y), 0);

            //This line of code actually spawns the object. Ignore 'Quaternion.identity' for now
            Instantiate(SpawnedObject, where, Quaternion.identity);
        }
    }
}

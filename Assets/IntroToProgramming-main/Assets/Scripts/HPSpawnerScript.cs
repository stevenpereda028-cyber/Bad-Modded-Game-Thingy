using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPSpawnerScript : MonoBehaviour
{
    //This number tracks how much time there is until the next item spawns
    //It changes in real time, always counting down to 0
    public float CoolDown;

    //This number tracks how much time there is between items spawning
    //It never changes, but Countdown uses it to know what to reset to after triggering
    public float SpawnTime;

    //This is the object that should spawn when the timer triggers. It can be any prefab
    public GameObject SpawnedObject;

    //This sets how far from the spawner the spawned object can spawn
    //The object spawns in a random location within this x and y distance of the spawner
    //If set to 0,0, the object always spawns right on top of the spawner
    public Vector2 Range;
    
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        //Every frame, make the Countdown variable go down in real time.
        CoolDown -= Time.deltaTime;

        //If Countdown hits 0, that means it's time to spawn the new object
        if (CoolDown < 0f)
        {
            //Finally, reset the Countdown timer so that the countdown starts all over again
            CoolDown = SpawnTime;

            //First we decide where the object should spawn.
            //We take the spawner's position (transform.position) and offset it by the random spawn range
            Vector3 where = transform.position + new Vector3(Random.Range(-Range.x, Range.x),
                Random.Range(-Range.y, Range.y), 0);

            //This line of code actually spawns the object. Ignore 'Quaternion.identity' for now
            Instantiate(SpawnedObject, where, Quaternion.identity);

        }
    }
}

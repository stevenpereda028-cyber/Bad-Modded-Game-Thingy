using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Player1Script : MonoBehaviour
{
    public Transform T;
    
    //The Rigidbody2D is a component that gives the player physics, and is what we use to move
    public Rigidbody2D RB;

    //TextMeshPro is a component that draws text on the screen.
    //We use this one to show our score.
    public TextMeshPro ScoreText;
    
    //This will control how fast the player moves
    public float Speed = 5;
    
    //This is how many points we currently have
    public int HP = 3;

    public float Cooldown;

    public float CooldownReference;

    public Vector2 Range;

    //Start automatically gets triggered once when the objects turns on/the game starts
    void Start()
    {
        //During setup we call UpdateScore to make sure our score text looks correct
        UpdateScore();
    }

    //Update is a lot like Start, but it automatically gets triggered once per frame
    //Most of an object's code will be called from Update--it controls things that happen in real time
    void Update()
    {
        //The code below controls the character's movement
        //First we make a variable that we'll use to record how we want to move
        Vector2 vel = new Vector2(0,0);
        
        //Then we use if statement to figure out what that variable should look like
        
        //If I hold the right arrow key, the player should move right. . .
        if (Keyboard.current.dKey.isPressed)
        {
            vel.x = Speed;
        }
        //If I hold the left arrow, the player should move left. . .
        if (Keyboard.current.aKey.isPressed)
        {
            vel.x = -Speed;
        }
        //If I hold the up arrow, the player should move up. . .
        if (Keyboard.current.wKey.isPressed)
        {
            vel.y = Speed;
        }
        //If I hold the down arrow, the player should move down. . .
        if (Keyboard.current.sKey.isPressed)
        {
            vel.y = -Speed;
        }
        
        //Finally, I take that variable and I feed it to the component in charge of movement
        RB.linearVelocity = vel;

        //Set player domain

        if (T.position.x < -10f)
        {
            Vector3 pos = T.position;
            pos.x = -10f;
            T.position = pos;
        }
        if (T.position.x > -3f)
        {
            Vector3 pos = T.position;
            pos.x = -3f;
            T.position = pos;
        }

        if (T.position.y > 5.5f)
        {
            Vector3 pos = T.position;
            pos.y = -5f;
            T.position = pos;
        }
        if (T.position.y < -5.5f)
        {
            Vector3 pos = T.position;
            pos.y = 5f;
            T.position = pos;
        }

    }

    //This gets called whenever you bump into another object, like a wall or coin.
    private void OnCollisionEnter2D(Collision2D other)
    {
        //This checks to see if the thing you bumped into had the Hazard tag
        BulletScript Hazard = other.gameObject.GetComponent<BulletScript>();
        //If it does...
        if (Hazard != null)
        {
            //Send message back that contact was made
            Hazard.GetBumped();
            //Make score variable decrease by 1
            HP--;
            //Update score text 
            UpdateScore();
        }
        
        //This checks to see if the thing you bumped into has the CoinScript script on it
        CoinScript coin = other.gameObject.GetComponent<CoinScript>();
        //If it does, run the code block belows
        if (coin != null)
        {
            //Tell the coin that you bumped into them so they can self destruct or whatever
            coin.GetBumped();
            //Make your score variable go up by one. . .
            HP++;
            //And then update the game's score text
            UpdateScore();
        }

    }

    //This function updates the game's score text to show how many points you have
    //Even if your 'score' variable goes up, if you don't update the text the player doesn't know
    private void UpdateScore()
    {
        ScoreText.text = "Player 1 HP: " + HP;
    }
}

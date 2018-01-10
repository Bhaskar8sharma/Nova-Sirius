using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Exit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // this gives you access to the back button
        {
            Application.Quit(); // this quits the game.
        }
    }
}

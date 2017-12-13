using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour {

    // Use this for initialization
    public static SoundScript Instance;

   
    public AudioClip playerShotSound;
    

    void Awake()
    {
        // Register the singleton
        if (Instance != null)
        {
            Debug.LogError("Multiple instances of SoundEffectsHelper!");
        }
        Instance = this;
    }

    

    public void MakePlayerShotSound()
    {
        MakeSound(playerShotSound);
    }

    

    /// <summary>
    /// Play a given sound
    /// </summary>
    /// <param name="originalClip"></param>
    private void MakeSound(AudioClip originalClip)
    {
        // As it is not 3D audio clip, position doesn't matter.
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }
}

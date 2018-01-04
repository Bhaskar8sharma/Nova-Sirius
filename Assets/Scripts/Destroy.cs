using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public float destroytime;
	// Use this for initialization
	void Start () {

        Destroy(this.gameObject,destroytime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(GameObject.FindWithTag("Player"));
        }
        
    }
}

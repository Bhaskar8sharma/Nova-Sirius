using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTarget : MonoBehaviour {

   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Leg"))
        {
           
            Destroy(col.gameObject);
            Destroy(this.gameObject);

        }
    }
   
}

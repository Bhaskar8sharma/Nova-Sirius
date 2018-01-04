using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour {
    public float speedFactor;
    public GameObject EnemyBullet;
    public float delay;

	// Use this for initialization
	void Start () {

        StartCoroutine(Shoots());
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    IEnumerator Shoots()
    {
        while(true)
        {
            yield return new WaitForSeconds(delay);
            GameObject clone = (GameObject)Instantiate(EnemyBullet, transform.position, Quaternion.identity);

            clone.GetComponent<Rigidbody2D>().velocity = -transform.right * speedFactor;
            
        }
    }
}

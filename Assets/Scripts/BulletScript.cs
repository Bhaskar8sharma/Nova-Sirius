using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    // Use this for initialization
    public float velx = 5f;

    float vely = 0f;

    Rigidbody2D bulletRigidbody2d;

    // Use this for initialization
    void Start()
    {

        bulletRigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        bulletRigidbody2d.velocity = new Vector2(velx, vely);
        Destroy(gameObject, 3f);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Enemygreen2")
        {
            Destroy(col.gameObject);
        }

        else if (col.gameObject.name == "Enemygreen")
        {
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "Enemyblue2")
        {
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "Enemyblue")
        {
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "EnemyRed2")
        {
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "EnemyRed1")
        {
            Destroy(col.gameObject);
        }
        
    }
}

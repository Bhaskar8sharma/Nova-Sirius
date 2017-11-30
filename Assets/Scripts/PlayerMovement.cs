using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;

    private Rigidbody2D myRigidBody;

    public Sprite red;
    public Sprite blue;
    public Sprite green;

    SpriteRenderer sr;

    public GameObject BulletRed;
    public GameObject BulletBlue;
    public GameObject BulletYellow;

    Vector2 bulletPos;
    public float fireRate = 2f;

    float nextFire = 0.1f;

    // Use this for initialization
    void Start()
    {

        myRigidBody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }


    void FixedUpdate()
    {
        if (Input.GetKeyDown("a") && Time.time > nextFire)
        {
            sr.sprite = red;
            nextFire = Time.time + fireRate;
            
            fireRedBullet();
        }

        if (Input.GetKeyDown("s") && Time.time > nextFire)
        {
            sr.sprite = blue;
            nextFire = Time.time + fireRate;
            
            fireBlueBullet();
        }

        if (Input.GetKeyDown("d") && Time.time > nextFire)
        {
            sr.sprite = green;
            nextFire = Time.time + fireRate;
            
            fireYellowBullet();
        }

        //if (Input.GetKey("left"))
        //{
        //    transform.Translate(Vector2.left * Time.deltaTime * speed);
        //    //Vector2 position = this.transform.position;
        //    //position.x--;
        //    //this.transform.position = position;
        //}
        //if (Input.GetKey("right"))
        //{
        //    transform.Translate(Vector2.right * Time.deltaTime * speed);
        //    //Vector2 position = this.transform.position;
        //    //position.x++;
        //    //this.transform.position = position;
        //}
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
            //    Vector2 position = this.transform.position;
            //    position.y++;
            //    this.transform.position = position;
        }

        if (Input.GetKey("down"))
        {

            transform.Translate(Vector2.down * Time.deltaTime * speed);
            //Vector2 position = this.transform.position;
            //position.y--;
            //this.transform.position = position;
        }
    }

    void fireRedBullet()
    {
        bulletPos = transform.position;

        bulletPos += new Vector2(1f, -0.43f);

        Instantiate(BulletRed, bulletPos, Quaternion.identity);
    }

    void fireBlueBullet()
    {
        bulletPos = transform.position;

        bulletPos += new Vector2(1f, -0.43f);

        Instantiate(BulletBlue, bulletPos, Quaternion.identity);
    }

    void fireYellowBullet()
    {
        bulletPos = transform.position;

        bulletPos += new Vector2(1f, -0.43f);

        Instantiate(BulletYellow, bulletPos, Quaternion.identity);
    }
    //private void OnCollisionEnter2D(Collision2D col)
    //{
    //    if (col.gameObject.name == "Enemygreen2")
    //    {
    //        Destroy(col.gameObject);
    //    }

    //    else if (col.gameObject.name == "Enemygreen")
    //    {
    //        Destroy(col.gameObject);
    //    }
    //    else if (col.gameObject.name == "Enemyblue2")
    //    {
    //        Destroy(col.gameObject);
    //    }
    //    else if (col.gameObject.name == "Enemyblue")
    //    {
    //        Destroy(col.gameObject);
    //    }
    //    else if (col.gameObject.name == "EnemyRed2")
    //    {
    //        Destroy(col.gameObject);
    //    }
    //    else if (col.gameObject.name == "EnemyRed1")
    //    {
    //        Destroy(col.gameObject);
    //    }


    //}

}

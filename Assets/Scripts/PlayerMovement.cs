using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour {

    public float LevelStartDelay = 0.1f;
    public Image Level2Image;
    public Text Level2Text;
    public Image GameOverImage;
    public Text GameOverText;
    public float speed;

    public AudioClip shootSound;

    private AudioSource source;


    private Rigidbody2D myRigidBody;

    public Sprite red;
    public Sprite blue;
    public Sprite green;

    SpriteRenderer sr;

    public GameObject BulletRed;
    public GameObject BulletBlue;
    public GameObject BulletGreen;


    Vector2 bulletPos;
    public float fireRate = 0.1f;

    float nextFire = 0.1f;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start()
    {
        Level2Text.enabled = true;
        Level2Image.enabled = true;
        GameOverText.enabled = false;
        GameOverImage.enabled = false;
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
            
            fireGreenBullet();
        }
        
        // X axis
        if (transform.position.x <= -3f)
        {
            transform.position = new Vector2(-3f, transform.position.y);
        }
        else if (transform.position.x >= 10.6f)
        {
            transform.position = new Vector2(10.6f, transform.position.y);
        }

        // Y axis
        if (transform.position.y <= -3.5f)
        {
            transform.position = new Vector2(transform.position.x, -3.5f);
        }
        else if (transform.position.y >= 12f)
        {
            transform.position = new Vector2(transform.position.x, 12f);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
            //Vector2 position = this.transform.position;
            //position.x--;
            //this.transform.position = position;
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
            //Vector2 position = this.transform.position;
            //position.x++;
            //this.transform.position = position;
        }
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

        //source.PlayOneShot(shootSound);
        SoundScript.Instance.MakePlayerShotSound();
    }

    void fireBlueBullet()
    {
        bulletPos = transform.position;

        bulletPos += new Vector2(1f, -0.43f);

        Instantiate(BulletBlue, bulletPos, Quaternion.identity);

        SoundScript.Instance.MakePlayerShotSound();
    }

    void fireGreenBullet()
    {
        bulletPos = transform.position;

        bulletPos += new Vector2(1f, -0.43f);

        Instantiate(BulletGreen, bulletPos, Quaternion.identity);

        SoundScript.Instance.MakePlayerShotSound();
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            GameOverText.enabled = true;
            GameOverImage.enabled = true;
            Destroy(this.gameObject);
        }
       
    }

}

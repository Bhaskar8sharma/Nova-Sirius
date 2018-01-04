using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{

    public Image GameOverImage;
    public Text GameOverText;

    public float speed;

    public AudioClip shootSound;

    private AudioSource source;

    private Rigidbody2D myRigidBody;

    public Sprite red;
    public Sprite blue;
    public Sprite green;
    public Sprite black;

    SpriteRenderer sr;

    public GameObject BulletRed;
    public GameObject BulletBlue;
    public GameObject BulletGreen;
    public GameObject BlackBullet;


    Vector2 bulletPos;
    public float fireRate = 0.1f;

    float nextFire = 0.1f;
    void Awake()
    {
       
       source = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start()
    {
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

        if (Input.GetKeyDown("w") && Time.time > nextFire)
        {
            sr.sprite = black;
            nextFire = Time.time + fireRate;

            fireBlackBullet();
        }

        //// X axis
        //if (transform.position.x <= -3f)
        //{
        //    transform.position = new Vector2(-3f, transform.position.y);
        //}
        //else if (transform.position.x >= 10.6f)
        //{
        //    transform.position = new Vector2(10.6f, transform.position.y);
        //}

        // Y axis
        if (transform.position.y <= -2.5f)
        {
            transform.position = new Vector2(transform.position.x, -2.5f);
        }
        else if (transform.position.y >= 25f)
        {
            transform.position = new Vector2(transform.position.x, 25f);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);

        }
        if (Input.GetKey("right"))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);

        }
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);

        }

        if (Input.GetKey("down"))
        {

            transform.Translate(Vector2.down * Time.deltaTime * speed);

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
    void fireBlackBullet()
    {
        bulletPos = transform.position;
        bulletPos += new Vector2(1f, -0.43f);
        Instantiate(BlackBullet, bulletPos, Quaternion.identity);
        SoundScript.Instance.MakePlayerShotSound();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
            GameOverText.enabled = true;
            GameOverImage.enabled = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour
{
    public UiManager ui;
    // Use this for initialization
    public float velx = 0.1f;

    float vely = 0.1f;

    Rigidbody2D bulletRigidbody2d;

    // Use this for initialization
    void Start()
    {
        ui = GameObject.FindWithTag("ui").GetComponent<UiManager>();
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
        if (col.gameObject.CompareTag("Enemy"))
        {
            ui.IncrementScore();
            Destroy(col.gameObject);
        }
    }
}
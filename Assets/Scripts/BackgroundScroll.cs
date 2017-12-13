using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {

    public float speed;
    Vector3 start;
    //public Vector2 speed = new Vector2(2, 2);

    //public Vector2 direction = new Vector2(-1, 0);

    //public bool isLinkedToCamera = false;

        void Start()
    {
        start = transform.position;
    }
    void Update()
    {

        transform.Translate((new Vector3(-1, 0, 0)) * speed * Time.deltaTime);

        if (transform.position.x < -13)

        { transform.position = start; }
        //Vector3 movement = new Vector3(
        //  speed.x * direction.x,
        //  speed.y * direction.y,
        //  0);

        //movement *= Time.deltaTime;
        //transform.Translate(movement);

        //// Move the camera
        //if (isLinkedToCamera)
        //{
        //    Camera.main.transform.Translate(movement);
        //}
    }
}

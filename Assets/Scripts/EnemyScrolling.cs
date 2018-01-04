using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScrolling : MonoBehaviour
{
    public float speed;
    Vector3 start;
    void Start()
    {
        start = transform.position;
    }
    void Update()
    {

        transform.Translate((new Vector3(-1, 0, 0)) * speed * Time.deltaTime);

        if (transform.position.x < -22.24)

        { transform.position = start; }
    }
}

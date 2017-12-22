using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTarget : MonoBehaviour
{
   
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Arm"))
        {

            Destroy(col.gameObject);
            Destroy(this.gameObject);

        }
    }
    
}

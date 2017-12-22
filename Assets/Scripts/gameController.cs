using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int bossParts;
    public Text GameOverText;
    private void Start()
    {
        GameOverText.text = "";
    }
    private void Update()
    {
        bossParts = gameObject.transform.childCount;
        if (bossParts == 0)
        {
            Debug.Log("Game Over");
            GameOverText.text = "Hurray! You did it." ;
        }
    }

    
}



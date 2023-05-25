using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pureya : MonoBehaviour
{

    void Start()
    {
        Application.targetFrameRate = 60;
    }


    void Update()
    {
        //¶–îˆó‚ª‰Ÿ‚³‚ê‚½
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);
        }
        //‰E–îˆó‚ª‰Ÿ‚³‚ê‚½
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);
        }


    }
}

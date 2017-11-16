using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skrra : MonoBehaviour
{


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Camera.main.transform.Translate(1, 3, 1);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEntry : MonoBehaviour
{
    int number=0;

    public GameObject go1, go2, go3;



    // Update is called once per frame
    void Update()
    {
        Invoke("numberCounter", 1f);
        if (number != 0)
        {
            go1.SetActive(false);
            go2.SetActive(false);
            go3.SetActive(false);
        }
    }

    void numberCounter()
    {
        number++;
    }
}

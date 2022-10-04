using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject player;

    public bool UpOn;
    public bool DownOn;
    public bool LeftOn;
    public bool RightOn;

    float Px;
    float Py;

    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.Find("Player");

        Px = GameObject.Find("Player").transform.position.x;
        Py = GameObject.Find("Player").transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {      
        if(Px < -8.5 )
        {
            LeftOn = false;
        }
        else if(Px > -8.5 && Px < 8.5)
        {
            LeftOn  = true;
        }

        if(Px > 8.5)
        {
            RightOn = false;
        }
        else if(Px > -8.5 && Px < 8.5)
        {
            RightOn = true;
        }

        if (Py < -4.5)
        {
            DownOn = false;
        }
        else if (Py > 4.5)
        {
            UpOn = true;
        }
    }
}

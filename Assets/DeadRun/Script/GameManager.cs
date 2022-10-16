using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ESC;
    public bool escOn;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {                           
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            escOn = true; //ESC Å° ÀÔ·Â Áß ÃÑ¾Ë»ý¼º X
            Time.timeScale = 0; //½Ã°£¸ØÃã
            Instantiate(ESC);           
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ESC;
    public bool escOn;
    bool ManyEsc;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ManyEsc = escOn;
        if (Input.GetKeyDown(KeyCode.Escape) && ManyEsc == false)
        {
            escOn = true; //ESC Ű �Է� �� �Ѿ˻��� X
            Time.timeScale = 0; //�ð�����
            Instantiate(ESC);           
        }
    }
}

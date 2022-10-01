using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    GameObject Btn;
    public bool IsStart;

    // Start is called before the first frame update
    void Start()
    {
        Btn = GameObject.Find("Button");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtnClick()
    {
       
        Destroy(Btn);
        IsStart = true;

    }
}

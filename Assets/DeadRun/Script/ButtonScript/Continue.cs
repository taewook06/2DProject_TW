using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Continue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ConBtn()
    {    
        Destroy(GameObject.Find("ESC(Clone)"));
        GameObject.Find("GameManager").GetComponent<GameManager>().escOn = false;
        Time.timeScale = 1;
    }
}

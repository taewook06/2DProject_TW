using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueBtn2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ConBtn2()
    {
        Destroy(GameObject.Find("ESC1(Clone)"));
        GameObject.Find("GameManager").GetComponent<GameManager>().escOn = false;
        Time.timeScale = 1;
    }
}

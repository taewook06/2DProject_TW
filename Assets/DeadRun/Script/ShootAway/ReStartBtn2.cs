using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReStartBtn2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restart2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("InGame2");
        Time.timeScale = 1;
    }
}

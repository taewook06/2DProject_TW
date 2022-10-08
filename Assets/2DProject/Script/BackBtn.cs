using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBtn : MonoBehaviour
{
    public GameObject Main;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Back()
    {

        Destroy(GameObject.Find("OptionManager"));
        Instantiate(Main);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
    }
}

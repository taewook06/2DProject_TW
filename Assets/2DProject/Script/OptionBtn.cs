using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionBtn : MonoBehaviour
{
    public GameObject Option;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Remove()
    {
        Destroy(GameObject.Find("MainCanvas"));
        Instantiate(Option);
    }
}

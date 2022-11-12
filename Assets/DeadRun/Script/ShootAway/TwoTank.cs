using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoTank : MonoBehaviour
{
    public GameObject Tank2;
    public GameObject Tank3;
    public GameObject Tank4;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("TankMake2", 15f);
        Invoke("TankMake3", 35f);
        Invoke("TankMake4", 60f);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Score").GetComponent<Text>().text = "Score: " + score;
    }
    void TankMake2()
    {
        Instantiate(Tank2);
    }
    void TankMake3()
    {
        Instantiate(Tank3);
    }
    void TankMake4()
    {
        Instantiate(Tank4);
    }

}

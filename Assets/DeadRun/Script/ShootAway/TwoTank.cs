using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoTank : MonoBehaviour
{
    public GameObject Tank;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("TankMake", 30f);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Score").GetComponent<Text>().text = "Score: " + score;
    }
    void TankMake()
    {
        Instantiate(Tank);
    }
}

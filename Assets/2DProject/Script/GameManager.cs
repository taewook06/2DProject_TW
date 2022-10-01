using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if (player.transform.position.x > 8.5 || player.transform.position.x < -8.5 || player.transform.position.y > 4.5 || player.transform.position.y < -4.5)
        {
            GameObject.Find("Btn").GetComponent<Button>().IsStart = false;
            GameObject.Find("GameOver").GetComponent<Text>().text = "Game Over";
        }
      
    }
}

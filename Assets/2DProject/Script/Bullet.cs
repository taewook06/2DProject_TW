using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public float Speed = -0.01f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Btn").GetComponent<Button>().IsStart == true)
        {
            gameObject.transform.Translate(Vector3.down * Speed);
            if (Input.GetMouseButtonDown(0))
            {
                Speed -= 0.002f;
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player") //닿으면 IsUpArrow를 true -> RyGenerator스크립트에 신호주기
        {
            GameObject.Find("Btn").GetComponent<Button>().IsStart = false;
            GameObject.Find("GameOver").GetComponent<Text>().text = "Game Over";
        }
    }
}
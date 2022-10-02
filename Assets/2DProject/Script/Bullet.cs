using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public float Speed = -0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Btn").GetComponent<Button>().IsStart == true)
        {
            gameObject.transform.Translate(Vector3.down * Speed); //Speed값만큼 속도로 이동
            if (Input.GetMouseButtonDown(0))
            {   //다음에 나올 탄막 속도 조절
               // Speed -= 0.02f;       
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player") //탄막이 플레이어와 닿았을 시
        {
           // GameObject.Find("Btn").GetComponent<Button>().IsStart = false; 
           // GameObject.Find("GameOver").GetComponent<Text>().text = "Game Over";
        }
        if (collision.transform.tag == "Wall") //탄막이 벽에 닿았을 시
        { //튕김 대체
            if (gameObject.transform.position.x > 8 || gameObject.transform.position.x < -8)
            {
                gameObject.transform.Translate(Vector3.up * -10f);
                Debug.Log("x");
            }
            else if (gameObject.transform.position.y > 4.5 || gameObject.transform.position.y < -4.5)
            {
                gameObject.transform.Translate(Vector3.up * -5);
                Debug.Log("y");
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    [HideInInspector]
    public float Speed;


    public bool BulletOn = false;
    SpriteRenderer render;
    GameObject player;
    Rigidbody2D rgd;
    public Vector2 Myvelocity;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        player = GameObject.Find("Player");
        rgd = GetComponent<Rigidbody2D>(); 
        Myvelocity = transform.up * Speed * 100; 
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Btn").GetComponent<Button>().IsStart == true)
        {
            rgd.velocity = Myvelocity;
            //  gameObject.transform.Translate(Vector3.down * Speed); //Speed값만큼 속도로 이동
            if( BulletOn == true)
            {
                render.color = new Color(255, 255, 0, 255);
                

            }
          
            
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GameObject.Find("Btn").GetComponent<Button>().IsStart == true)
        {
           
            if (collision.transform.tag == "Wall") //탄막이 벽에 닿았을 시
            {
                BulletOn = true; //총알활성화
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player" && BulletOn == true) //탄막이 플레이어와 닿고, 총알이 활성화 됐다면
        {
            Destroy(player);
            GameObject.Find("Btn").GetComponent<Button>().IsStart = false;
            GameObject.Find("GameOver").GetComponent<Text>().text = "Game Over";
        }
    }
}

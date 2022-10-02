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
            //  gameObject.transform.Translate(Vector3.down * Speed); //Speed����ŭ �ӵ��� �̵�
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
           
            if (collision.transform.tag == "Wall") //ź���� ���� ����� ��
            {
                BulletOn = true; //�Ѿ�Ȱ��ȭ
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player" && BulletOn == true) //ź���� �÷��̾�� ���, �Ѿ��� Ȱ��ȭ �ƴٸ�
        {
            Destroy(player);
            GameObject.Find("Btn").GetComponent<Button>().IsStart = false;
            GameObject.Find("GameOver").GetComponent<Text>().text = "Game Over";
        }
    }
}

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

    public GameObject Over;
       
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
        
            rgd.velocity = Myvelocity;
            
            if(this.gameObject.layer == 8) 
            {
                render.color = new Color(255, 255, 0, 255);          
            }
        
    }    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player" && this.gameObject.layer == 8) //총알이 플레이어와 닿고, 총알이 활성화 됐다면
        {
            GameObject.Find("DeadSound").GetComponent<AudioSource>().Play();
            Destroy(player);
            GameObject.Find("GameOver").GetComponent<Text>().text = "Game Over";
            Instantiate(Over);
        }    
        if(collision.transform.tag == "Wall")
        {
            gameObject.GetComponent<AudioSource>().Play();
            this.gameObject.layer = 8; //총알활성화 레아어
        }
    }
}

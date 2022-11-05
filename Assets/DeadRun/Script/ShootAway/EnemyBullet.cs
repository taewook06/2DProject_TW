using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBullet : MonoBehaviour
{
    public GameObject Over;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.down * -0.03f);
        Destroy(gameObject, 3f);
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Time.timeScale = 0;
            GameObject.Find("DeadSound").GetComponent<AudioSource>().Play();
            GameObject.Find("GameOver").GetComponent<Text>().text = "Game Over";
            Instantiate(Over);
            GameObject.Find("Player").GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Ptail").GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Player").GetComponent<PlayerMove2>().Die = true;
            Destroy(gameObject);
        }
    }
}

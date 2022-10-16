using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    GameObject EnemyOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.down * -0.03f);
        Invoke("BulletDestroy", 2f);
             
    }
    void BulletDestroy()
    {
        Destroy(gameObject);
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            GameObject Enemy = collision.transform.gameObject;
           // Destroy(Enemy);          
        }       
     }
}

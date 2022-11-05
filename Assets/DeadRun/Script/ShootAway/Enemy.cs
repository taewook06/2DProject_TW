using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;
    Transform target;
    Vector3 Pos;

    float followspeed = 3f;
    public bool EnemyMove;
    public bool BulletOn;
    public GameObject EnemyBulletPrefab;
    public bool CoolTime;

    void Start()
    {
        CoolTime = true;
        EnemyMove = true;
        Pos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {      
        if (EnemyMove == true )
        {
            FollowTarget();
        }    
        
        if (CoolTime == true && BulletOn == true)
        {
            //gameObject.GetComponent<AudioSource>().Play();
            GameObject bullet = Instantiate(EnemyBulletPrefab,transform.position, transform.rotation);   //(≈∫∏∑¿Ã,¥Î∆˜≤ø∏Æø°, ≤ø∏ÆπÊ«‚¿∏∑Œ)
            gameObject.GetComponent<AudioSource>().Play();
            CoolTime = false;
            Invoke("Delay", 1.0f);
        }
    }
    void Delay()
    {
        CoolTime = true;
    }

    void FollowTarget()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, followspeed * Time.deltaTime);
        if (Pos != transform.position)
        {
            Vector3 norTar = (Pos - transform.position).normalized;
            float angle = Mathf.Atan2(norTar.y, norTar.x) * Mathf.Rad2Deg;

            // rotate to angle

            Quaternion rotation = new Quaternion();
            rotation.eulerAngles = new Vector3(0, 0, angle + 90);
            transform.rotation = rotation;

            Pos = transform.position;
        }
    }
  
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player" )
        {
            EnemyMove = false;
            BulletOn = true;
        }              
    }
     void OnTriggerExit2D(Collider2D collision)
     {
        EnemyMove = true;
        BulletOn = false;
     }    
}

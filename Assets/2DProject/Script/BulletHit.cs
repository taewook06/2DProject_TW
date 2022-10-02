using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
   
    
    public Rigidbody2D rigid;
    Vector3 lastVelocity;
    public Bullet myBullet;

    private void Update()
    {
       
             lastVelocity = rigid.velocity;
      
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (GameObject.Find("Btn").GetComponent<Button>().IsStart == true)
        {
            var speed = lastVelocity.magnitude;
            var dir = Vector2.Reflect(lastVelocity.normalized, coll.contacts[0].normal);

            myBullet.Myvelocity = dir * Mathf.Max(speed, 0f);
        }
    }
}


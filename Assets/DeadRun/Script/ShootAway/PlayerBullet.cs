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
        Destroy(gameObject, 3f);
    }    
     void OnTriggerEnter2D(Collider2D other)
     {
        if (other.gameObject.tag == "EnemyHit")
        {
            Destroy(other.transform.parent);
        }
     }
}

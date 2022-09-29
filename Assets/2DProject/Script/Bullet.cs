using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float BulletSpeed = 3;

    // Start is called before the first frame update
    void Start()
    {
       // GetComponent<Rigidbody>().AddForce(transform.forward * BulletSpeed, ForceMode.Impulse);
       //
        //Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

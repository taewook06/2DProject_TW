using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    Vector3 Pos;
    float Speed = 50f;   
    Vector2 movement = new Vector2();

    Rigidbody2D myRig;

    bool ESC;

    // Start is called before the first frame update
    void Start()
    {
        myRig = GetComponent<Rigidbody2D>();
        Pos = transform.position;       
    }

    // Update is called once per frame
    void Update()
    {
        ESC = GameObject.Find("GameManager").GetComponent<GameManager>().escOn;

        if (ESC == false) //ESC중 움직임 X
        {
            movement.x = Input.GetAxisRaw("Horizontal");  //수평이동 명령어  
            movement.y = Input.GetAxisRaw("Vertical");

            movement.Normalize(); //백터 정규화

            transform.position = new Vector2(transform.position.x + movement.x * Speed * 0.001f, transform.position.y + movement.y * Speed * 0.001f);

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
    }
}

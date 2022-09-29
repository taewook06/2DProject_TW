using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector3 position;
    public float Speed = 3;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            position.x -= Speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 90);          
        }
        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            position.x += Speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, -90);

        }
        if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.UpArrow)))
        {
            position.y += Speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.DownArrow)))
        {
            position.y -= Speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 180);
            //slerp
        }


        transform.position = position;

    }
    void FixedUpdate()
    {

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);

        transform.position -= transform.forward * Time.deltaTime * Speed;


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    Vector3 Pos;
    public float Speed = 3;
    GameObject player;
    GameObject spone;

    // Start is called before the first frame update
    void Start()
    {
        Pos = transform.position;
        player = GameObject.Find("Player");
        spone = GameObject.Find("Spone");
    }

    // Update is called once per frame
    void Update()
    {
       if (GameObject.Find("Btn").GetComponent<Button>().IsStart == true)
       {
            if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
            {
                Pos.x -= Speed * Time.deltaTime;
            }
            if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
            {
                Pos.x += Speed * Time.deltaTime;

            }
            if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.UpArrow)))
            {
                Pos.y += Speed * Time.deltaTime;

            }
            if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.DownArrow)))
            {
                Pos.y -= Speed * Time.deltaTime;
            }

            if (Pos != transform.position)
            {
                // get the angle

                Vector3 norTar = (Pos - transform.position).normalized;
                float angle = Mathf.Atan2(norTar.y, norTar.x) * Mathf.Rad2Deg;

                // rotate to angle

                Quaternion rotation = new Quaternion();
                rotation.eulerAngles = new Vector3(0, 0, angle - 90);
                transform.rotation = rotation;
            }
       }       

        transform.position = Pos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Bullet") //닿으면 IsUpArrow를 true -> RyGenerator스크립트에 신호주기
        {
           
        }
    }


}

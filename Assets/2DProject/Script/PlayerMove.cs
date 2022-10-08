using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    Vector3 Pos;
    public float Speed = 5f;
    public bool WallCollider;
    Vector2 movement = new Vector2();

    Rigidbody2D myRig;

    // Start is called before the first frame update
    void Start()
    {
        myRig = GetComponent<Rigidbody2D>();
        Pos = transform.position;
        WallCollider = GetComponent<BoxCollider2D>().isTrigger; //플레이어의 콜라이더 불러옴
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Btn").GetComponent<Button>().IsStart == true)
        {

            movement.x = Input.GetAxisRaw("Horizontal");    
            movement.y = Input.GetAxisRaw("Vertical");

            movement.Normalize();

            transform.position = new Vector2(transform.position.x + movement.x * Speed*0.001f, transform.position.y + movement.y * Speed * 0.001f);

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

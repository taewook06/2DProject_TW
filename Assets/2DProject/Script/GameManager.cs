using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject player;
    bool WallCollide;

    float Px;
    float Py;

    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.Find("Player");
       WallCollide = GameObject.Find("Player").GetComponent<PlayerMove>().WallCollider; //플레이어의 콜라이더
               
    }

    // Update is called once per frame
    void Update()
    {
        Px = GameObject.Find("Player").transform.position.x;
        Py = GameObject.Find("Player").transform.position.y;
      
       if(Px < -8.5 || Px > 8.5 || Py < -4.5 || Py > 4.5) //화면밖으로 나가기 직전
       {
            WallCollide = false; //플레이어와 벽 충돌 가능
            Debug.Log("밖으로 나가기 직전");
       }
       else if (Px > -8.5 && Px < 8.5 && Py > -4.5 && Py < 4.5) //화면 안에 있을 때
       {
            WallCollide = true; //플레이어와 벽 충돌 불가능
            Debug.Log("화면 안에 있음");
       }
    }
}

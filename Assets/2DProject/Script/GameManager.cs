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
       WallCollide = GameObject.Find("Player").GetComponent<PlayerMove>().WallCollider; //�÷��̾��� �ݶ��̴�
               
    }

    // Update is called once per frame
    void Update()
    {
        Px = GameObject.Find("Player").transform.position.x;
        Py = GameObject.Find("Player").transform.position.y;
      
       if(Px < -8.5 || Px > 8.5 || Py < -4.5 || Py > 4.5) //ȭ������� ������ ����
       {
            WallCollide = false; //�÷��̾�� �� �浹 ����
            Debug.Log("������ ������ ����");
       }
       else if (Px > -8.5 && Px < 8.5 && Py > -4.5 && Py < 4.5) //ȭ�� �ȿ� ���� ��
       {
            WallCollide = true; //�÷��̾�� �� �浹 �Ұ���
            Debug.Log("ȭ�� �ȿ� ����");
       }
    }
}

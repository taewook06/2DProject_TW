using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletMake : MonoBehaviour
{
    public GameObject PlayerBulletPrefab;
    bool CoolTime;
    bool die;

    // Start is called before the first frame update
    void Start()
    {
        CoolTime = true;
        die = GameObject.Find("Player").GetComponent<PlayerMove2>().Die;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && die == false)  //ESCŰ�� ������ ���� �Ѿ� ���� X
        {
            if (CoolTime == true)
            {
                //gameObject.GetComponent<AudioSource>().Play();
                GameObject bullet = Instantiate(PlayerBulletPrefab, transform.position, transform.rotation);   //(ź����,����������, ������������)
                gameObject.GetComponent<AudioSource>().Play();
                CoolTime = false;
                Invoke("Delay", 1.0f);
            }

        }
    }
    void Delay()
    {
        CoolTime = true;
    }
}

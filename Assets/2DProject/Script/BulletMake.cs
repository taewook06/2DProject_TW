using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletMake : MonoBehaviour
{
    public GameObject BulletPrefab;
    public int Score = 0;
    float BulletSpeed = 0.01f;
    public bool CoolTime;

    // Start is called before the first frame update
    void Start()
    {
        CoolTime = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Btn").GetComponent<Button>().IsStart == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if(CoolTime == true)
                {
                    GameObject bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);   //(ź����,����������, ������������)
                    bullet.GetComponent<Bullet>().Speed = BulletSpeed;
                    Score += 1;
                    CoolTime = false;                    
                    Invoke("Delay", 1.0f);                   
                }
                

                BulletSpeed += 0.001f;              
                GameObject.Find("Point").GetComponent<Text>().text = "Score: " + Score;
              
            }
        }       
    }
    void Delay()
    {
        CoolTime = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMake : MonoBehaviour
{
    bool CoolTime;
    bool die;
    public GameObject EnemyPrefab;    
    float Level = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Delay", 2.0f);        
        die = GameObject.Find("Player").GetComponent<PlayerMove2>().Die;
    }

    // Update is called once per frame
    void Update()
    {       
        if (CoolTime == true)
        {
            //gameObject.GetComponent<AudioSource>().Play();
            GameObject bullet = Instantiate(EnemyPrefab, transform.position, transform.rotation);   //(ź����,����������, ������������)
            GameObject.Find("Twotank").GetComponent<TwoTank>().score += 1;                                                                                     
            CoolTime = false;
            Invoke("Delay", Level);
            Level -= 0.25f;
            if(Level == 0f)
            {
                Level += 0.25f;
            }
        }
    }
    void Delay()
    {
        CoolTime = true;
    }
}

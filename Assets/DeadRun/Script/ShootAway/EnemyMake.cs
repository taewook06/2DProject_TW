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
            GameObject bullet = Instantiate(EnemyPrefab, transform.position, transform.rotation);   //(≈∫∏∑¿Ã,¥Î∆˜≤ø∏Æø°, ≤ø∏ÆπÊ«‚¿∏∑Œ)
            GameObject.Find("tankSpawner").GetComponent<TwoTank>().score += 1;                                                                                     
            CoolTime = false;
            Invoke("Delay", Level);
            Level -= 0.2f;
            if(Level <= 2.8f)
            {
                Level = 2.8f;
            }
        }
    }
    void Delay()
    {
        CoolTime = true;
    }
}

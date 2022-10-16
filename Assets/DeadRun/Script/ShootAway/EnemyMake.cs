using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMake : MonoBehaviour
{
    bool CoolTime;
    bool die;
    public GameObject EnemyPrefab;

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
            CoolTime = false;
            Invoke("Delay", 5.0f);
        }
    }
    void Delay()
    {
        CoolTime = true;
    }
}

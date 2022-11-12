using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletMake : MonoBehaviour
{
    public GameObject PlayerBulletPrefab;
    bool CoolTime;
    bool die;
    bool ESC;

    // Start is called before the first frame update
    void Start()
    {
        CoolTime = true;
        die = GameObject.Find("Player").GetComponent<PlayerMove2>().Die;
       
    }

    // Update is called once per frame
    void Update()
    {
        ESC = GameObject.Find("GameManager").GetComponent<GameManager>().escOn;
        if (Input.GetMouseButtonDown(0) && die == false && ESC == false)  //ESCÅ°¸¦ ´­·¶À» ¶§´Â ÃÑ¾Ë »ý¼º X
        {
            if (CoolTime == true)
            {
                //gameObject.GetComponent<AudioSource>().Play();
                GameObject bullet = Instantiate(PlayerBulletPrefab, transform.position, transform.rotation);   //(Åº¸·ÀÌ,´ëÆ÷²¿¸®¿¡, ²¿¸®¹æÇâÀ¸·Î)
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletMake : MonoBehaviour
{
    public GameObject BulletPrefab;
    public int Score = 0;
    float BulletSpeed = 0.01f;
  
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Btn").GetComponent<Button>().IsStart == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);   //(≈∫∏∑¿Ã,¥Î∆˜≤ø∏Æø°, ≤ø∏ÆπÊ«‚¿∏∑Œ)
                bullet.GetComponent<Bullet>().Speed = BulletSpeed;

                BulletSpeed += 0.001f;
                Score += 1;
                GameObject.Find("Point").GetComponent<Text>().text = "Score: " + Score;
              
            }
        }       
    }
}

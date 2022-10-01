using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMake : MonoBehaviour
{
    public GameObject BulletPrefab;
  
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(BulletPrefab,transform.position, transform.rotation);   //(≈∫∏∑¿Ã,¥Î∆˜≤ø∏Æø°, ≤ø∏ÆπÊ«‚¿∏∑Œ)

        }
    }
}

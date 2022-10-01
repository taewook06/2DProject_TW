using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBounce : MonoBehaviour
{
    [SerializeField] [Range(500f, 2000f)] float speed = 1000f;
    public Rigidbody2D rb;
    float randomX, randomY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        randomX = Random.Range(-1f, 1f);
        randomY = Random.Range(-1f, 1f);

        Vector2 dir = new Vector2(randomX, randomY).normalized;

        rb.AddForce(dir * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

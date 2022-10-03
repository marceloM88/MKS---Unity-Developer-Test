using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Bullet
{


    // Start is called before the first frame update
    void Start()
    {
        
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            GameObject effect = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(effect, 0.35f);
            Destroy(gameObject);
        }
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

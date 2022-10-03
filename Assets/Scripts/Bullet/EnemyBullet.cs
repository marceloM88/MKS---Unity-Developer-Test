using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet
{
    

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Shooter")
        {
            GameObject effect = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(effect, 0.35f);
            Destroy(gameObject);
        }
    
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

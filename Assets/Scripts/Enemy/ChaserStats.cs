using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserStats : StatusClass
{
    public float explosionDamage;
    // Start is called before the first frame update
    void Start()
    {
        LifeStats();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            TakeDamage(collision.gameObject.GetComponent<Bullet>().damageValue);
            SpriteChange();
        }
        if (collision.gameObject.tag == "Player")
        {
            life = 0;
            SpriteChange();
        }
    
    }

    public override void SpriteChange()
     {
        base.SpriteChange();
        if (life <= 0)
        {
            
            this.GetComponent<ChaserMovement>().speed = 0;
            this.GetComponent<ChaserMovement>().target.GetComponent<PlayerStats>().AddPoints();
        }
        
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}

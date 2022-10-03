using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : StatusClass
{
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        LifeStats();
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Chaser")
        {
            TakeDamage(collision.gameObject.GetComponent<ChaserStats>().explosionDamage);
            SpriteChange();
        } 
        if (collision.gameObject.tag == "EnemyBullet")
        {
            TakeDamage(collision.gameObject.GetComponent<EnemyBullet>().damageValue);
            SpriteChange();
        }      
    
    }

    public override void SpriteChange()
    {
        base.SpriteChange();
        
        
    }
    public void AddPoints()
    {
        points++;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusClass : MonoBehaviour
{
    public SpriteRenderer spr;
    public float life;    
    private float maxlife;
    public GameObject explosionDeath;
    public Sprite spriteAvarageLife;
    public Sprite spriteLowLife;
    public Sprite spriteDeath;
    public Image Lifebar;
    float avarageLife;
    float lowLife;
    

    public void LifeStats()
    {
        maxlife = life;
        avarageLife = (life * 65)/100;
        lowLife = (life * 30)/100;
    }

    public void TakeDamage(float dano)
    {
        life -= dano;
        Lifebar.fillAmount = (life * 100 /maxlife ) / 100;
        
    }

    public virtual void SpriteChange()
    {
        if (life < avarageLife)
        {
            spr.sprite = spriteAvarageLife;

        }

        if (life < lowLife)
        {
            spr.sprite = spriteLowLife;
        }

        if (life <= 0)
        {
            spr.sprite = spriteDeath;                       
            GameObject effect = Instantiate(explosionDeath, transform.position, Quaternion.identity);
            Destroy(effect, 0.35f);
            Destroy(gameObject, 0.5f);            
            
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

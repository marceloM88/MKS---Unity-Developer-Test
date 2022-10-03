using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject shootSprite;
    public float shootCooldown1 = 5f;
    public float shootCooldown2 = 5f;
    float shootcd1 = 0;
    float shootcd2 = 0;
    public Transform FirePoint;
    public Transform FirePoint2;
    public Transform FirePoint3;
    public float shootForce = 0f;
    public KeyCode shootOne;
    public KeyCode shootTwo;
    // Start is called before the first frame update
    void Start()
    {
        shootcd1 = shootCooldown1;
        shootcd2 = shootCooldown2;
        shootCooldown1 = 0f;
        shootCooldown2 = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        shootCooldown1 -= Time.deltaTime;
        shootCooldown2 -= Time.deltaTime;
        if (Input.GetKeyDown(shootOne))
        {
           
            if (shootCooldown1 <= 0)
            {
                Shoot();
                shootCooldown1 = shootcd1;
            }
        }

        if (Input.GetKeyDown(shootTwo))
        {
           
            if (shootCooldown2 <= 0)
            {
                TrippleShoot();
                shootCooldown2 = shootcd2;
            }
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(shootSprite, FirePoint.position, FirePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.up * shootForce, ForceMode2D.Impulse);
    
    }

     void TrippleShoot()
    {
        GameObject bullet = Instantiate(shootSprite, FirePoint.position, FirePoint.rotation);
        GameObject bullet2 = Instantiate(shootSprite, FirePoint2.position, FirePoint2.rotation);
        GameObject bullet3 = Instantiate(shootSprite, FirePoint3.position, FirePoint3.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();
        Rigidbody2D rb3 = bullet3.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.up * shootForce, ForceMode2D.Impulse);
        rb2.AddForce(FirePoint2.up * shootForce, ForceMode2D.Impulse);
        rb3.AddForce(FirePoint3.up * shootForce, ForceMode2D.Impulse);
    
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterAttack : MonoBehaviour
{
    public float areaView;
    public Transform firePoint;
    public GameObject target;
    public float shootForce = 0f;
    public GameObject shootSprite;
    public float cooldownAttack;
    private float cdAttack;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player");
        cdAttack = cooldownAttack;
    }

    // Update is called once per frame
    void Update()
    {
       if (target != null)
       {
        float distance = (target.transform.position - transform.position).magnitude;
        cooldownAttack -= Time.deltaTime;
        
        if (distance <= areaView)
        {
            if (cooldownAttack <= 0)
            {
                Attack();
                cooldownAttack = cdAttack;
            }
            
        }
       }
    }
    void Attack()
    {
        Vector2 direction = target.transform.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
        GameObject bullet = Instantiate(shootSprite, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * shootForce, ForceMode2D.Impulse);

    }
}

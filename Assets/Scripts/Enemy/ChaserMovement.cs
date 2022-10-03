using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserMovement : MonoBehaviour
{
    public float speed;
    public float distance;
    public GameObject target;
    private Vector3 Direction;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
       if (target != null)
       {
        FollowPlayer();
       }
    }

    private void FollowPlayer()
    {
     if (target != null)
        {
            Direction = target.transform.position - transform.position;
            float AreaPlayer = Direction.magnitude;
            Direction = Direction.normalized;
            if (AreaPlayer > distance)
            {
                    
                    transform.position += Direction * Time.deltaTime * speed;
                    transform.up = Direction;
            }               
         }
        
    }
}

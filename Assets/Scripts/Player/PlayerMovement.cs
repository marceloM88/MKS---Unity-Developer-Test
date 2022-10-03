using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0f;
    public float rotationspeed = 0f;
    public KeyCode rotateLeft;
    public KeyCode rotateRight;
    public KeyCode Foward;

    Transform myT;
    Vector2 myPos;
    Vector3 myRot;
    float angle;  
    
    // Start is called before the first frame update
    void Start()
    {
        myT = transform;
        myPos = myT.position;
        myRot = myT.rotation.eulerAngles;
    }


 
    // Update is called once per frame
    void Update()
    {

       angle = myT.eulerAngles.magnitude * Mathf.Deg2Rad;

        if (Input.GetKey (rotateLeft))
        {
            myRot.z += rotationspeed;
        }
        if (Input.GetKey (rotateRight))
        {
            myRot.z -= rotationspeed;
        }
        if (Input.GetKey (Foward))
        {
            myT.position += speed * myT.up * Time.deltaTime;
        }       
       
       myT.rotation = Quaternion.Euler (myRot);   
       
    }

    
}

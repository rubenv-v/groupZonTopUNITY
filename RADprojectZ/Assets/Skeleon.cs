using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleon : MonoBehaviour
{
    float currentSpeed, walkingspeed = 2, runningspeed = 4;
    private float turningspeed = 100;
    Animator myAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = walkingspeed;
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myAnimator.SetBool("isWalking", false);


        if (Input.GetKey(KeyCode.W)) 
        {
            myAnimator.SetBool("isWalking",true);
            transform.position += currentSpeed * transform.forward * Time.deltaTime;
        }  

     if(Input.GetKey(KeyCode.S)) 
        {
            transform.position += currentSpeed * transform.forward * Time.deltaTime;
        }
  
     
       
    }

}

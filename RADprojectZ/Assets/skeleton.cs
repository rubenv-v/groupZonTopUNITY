using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class skeleton : MonoBehaviour
{
    public GameObject snowballCloneTemplate;

    Transform tr;
    Rigidbody rb;
#pragma warning disable CS0414 // The field 'skeleton.runningSpeed' is assigned but its value is never used
    float currentspeed, walkingspeed = 2, runningSpeed = 4;
#pragma warning restore CS0414 // The field 'skeleton.runningSpeed' is assigned but its value is never used
    private float turningSpeed = 180;
    Animator myAnimator;

    private static object GetDebuggerDisplay()
    {
        throw new NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
    tr = GetComponent<Transform>();
    rb = GetComponent<Rigidbody>();
    myAnimator = GetComponent<Animator>();
        currentspeed = walkingspeed;
    }

    // Update is called once per frame
    void Update()
{
        myAnimator.SetBool("isRun", false);

        if (Input.GetKey(KeyCode.W))
        {
            tr.position += currentspeed * tr.forward * Time.deltaTime;
        }

        myAnimator.SetBool("isRun", true);
  

        if (Input.GetKey(KeyCode.A))
        {

            tr.Rotate(Vector3.up, turningSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {

            tr.Rotate(Vector3.down, turningSpeed * Time.deltaTime);

        }

        if (Input.GetMouseButton(0))
        {
            GameObject newgo = Instantiate(snowballCloneTemplate);

            snowballcontrolscript mySnowball = newgo.GetComponent<snowballcontrolscript>();

            mySnowball.ImThrowingYou(this);
        }
    
}
}

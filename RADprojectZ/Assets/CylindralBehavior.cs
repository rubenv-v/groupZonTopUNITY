using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CylindralBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3 (0, 7, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.position += Vector3.forward * Time.deltaTime;     
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(Vector3.up,90 * Time.deltaTime);
        }

    }
}
      

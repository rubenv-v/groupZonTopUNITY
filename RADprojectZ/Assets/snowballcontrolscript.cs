using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowballcontrolscript : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 2, 4);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");

        DealWithHits thingIHit = collision.gameObject.GetComponent<DealWithHits>();
        if (thingIHit != null)
        {
            thingIHit.IHitYou();
        }
    }


    internal void ImThrowingYou(skeleton skeleton)
    {
        transform.position = skeleton.transform.position + 2 * Vector3.up + skeleton.transform.forward;
        rb = GetComponent<Rigidbody>();
        rb.velocity = 10 * (2 * Vector3.up + 3 * skeleton.transform.forward);
    }

}


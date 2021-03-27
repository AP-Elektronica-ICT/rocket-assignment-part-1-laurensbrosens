using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public float speed;
    public float torque;
    public Rigidbody rb;
    public Transform t;
    // Oude code staat nog gecomment in het script om te tonen wat ik geprobeerd heb
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            Quaternion q = rb.transform.rotation;
            //Vector3 v = q.eulerAngles;
            rb.AddForce(q * Vector3.up * speed * Time.deltaTime);
            //Debug.Log(v);
        }
        float turn = Input.GetAxis("Horizontal");
        rb.AddTorque(transform.right * torque * turn);
        /*
        if (!(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddTorque(0.25f, 0, 0); //.Rotate(0.25f,0,0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                float turn = Input.GetAxis("Horizontal");
                rb.AddTorque(transform.up * torque);
                //rb.transform.Rotate(-0.25f, 0, 0);
            }
        }*/
    }
}

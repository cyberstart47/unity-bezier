using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed ;
    public float turnspeed;

    public Vehicle(float speed,float turnspeed)
    {
        this.speed = speed;
        this.turnspeed = turnspeed;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Move Vehicle Forward
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, speed);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * turnspeed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * turnspeed * Time.deltaTime);
        }

    }
}
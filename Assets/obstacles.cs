using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    // Components
    Rigidbody rb;

    // Ball
    float speed = 5f;
    //float speedLimiter = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

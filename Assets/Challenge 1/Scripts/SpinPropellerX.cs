using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
     public float rotationSpeed;
    public float speed = 20.0f;
    public float forwardInput;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        //verticalInput = Input.GetAxis("Vertical");
        //forwardInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime * speed);//* verticalInput);
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime * speed);// * forwardInput);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float horizontalInput;
    public float verticalInput;
    public float rangeX = 24;
    public float rangeZ = 24;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);


        if(transform.position.x < -rangeX)
        {
         transform.position = new Vector3(-rangeX, transform.position.y, transform.position.z);   
        }

        if(transform.position.x > rangeX)
        {
         transform.position = new Vector3(rangeX, transform.position.y, transform.position.z);   
        }

        if(transform.position.x < -rangeZ)
        {
         transform.position = new Vector3(transform.position.x, transform.position.y, -rangeZ);   
        }

        if(transform.position.x > rangeZ)
        {
         transform.position = new Vector3(transform.position.x, transform.position.y, rangeX);   
        }
    }
}

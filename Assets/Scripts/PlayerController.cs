using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float horizontalInput;
    public float verticalInput;
    private float rangeX = 24;
    private float rangeZ = 24;
    public GameManager gm;

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

        if(transform.position.z < -rangeZ)
        {
         transform.position = new Vector3(transform.position.x, transform.position.y, -rangeZ);   
        }

        if(transform.position.z > rangeZ)
        {
         transform.position = new Vector3(transform.position.x, transform.position.y, rangeX);   
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "GoodCube")
        {
            gm.score += 1;
            
                Destroy(collision.gameObject);
                 

        }

            if(collision.gameObject.tag == "BadCube")
        {
            gm.score -= 5;
           
                Destroy(collision.gameObject);
        }   

        
    }



}
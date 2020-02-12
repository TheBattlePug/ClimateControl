using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{

    public float speedX = 2.0f;
    public float speedY = 2.0f;
   
    private float yDifference = 0.0f;
    private float xDifference = 90.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        yDifference += speedY * Input.GetAxis("Mouse X");
        xDifference -= speedX * Input.GetAxis("Mouse Y");
        


        transform.eulerAngles = new Vector3(xDifference, yDifference, 0.0f);

        if(Input.GetAxis("Mouse ScrollWheel") > 0) 
        {
            GetComponent<Camera>().fieldOfView--;            
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            GetComponent<Camera>().fieldOfView++;
        }


    }
}

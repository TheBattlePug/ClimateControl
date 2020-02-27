using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMovement : MonoBehaviour
{
    public static float earthSpeed = 0.01f;

    public static float timeCounter = 0;    
    public static float width = 4;
    //This was the original value (in the comment) may be used again if this new idea doesn't work
    //public static float height = 5;
    public static float height = 4;
    public static float yRotation = 0.5f;

    public static float EarthRotation = 0;

    

    // Start is called before the first frame update
    void Start()
    {
                 
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * earthSpeed;

        float x = Mathf.Cos(timeCounter) * width;
        float z = Mathf.Sin(timeCounter) * height;
        float y = 0;


        transform.Rotate(0, yRotation, 0);

        EarthRotation += yRotation;

        Mathf.Clamp(earthSpeed, 0.0f, 0.1f);

            


        transform.position = new Vector3(x, y, z);
        //make the speed go faster

        if (Input.GetButtonDown("IncreaseSpeed"))
        {
            earthSpeed += 0.01f;
        }
        else if (Input.GetButtonDown("DecreaseSpeed")) 
        {
            earthSpeed -= 0.01f;
        }
        
        
        
       
    }
}

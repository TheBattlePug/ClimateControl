using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMovement : MonoBehaviour
{
    public static float earthSpeed = 0.025f;

    public static float timeCounter = 0;    
    public static float width = 4;
    public static float height = 5;
   

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

        float yRotation = 0.5f;
        transform.Rotate(0, yRotation, 0);

        transform.position = new Vector3(x, y, z);
        
       
    }
}

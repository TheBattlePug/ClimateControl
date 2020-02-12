using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenMovement : MonoBehaviour
{
    float timeCounter = 0;

    float speed = EarthMovement.earthSpeed;
    float width = EarthMovement.width - 1;
    float height = EarthMovement.height - 1;

    

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * width;
        float z = Mathf.Sin(timeCounter) * height;


        float yRotation = (float)(90 / (56 * 63.0));

        //transform.Rotate(0, -1 * yRotation, 0);


        transform.position = new Vector3(x, 0.073f, z);
    }


}

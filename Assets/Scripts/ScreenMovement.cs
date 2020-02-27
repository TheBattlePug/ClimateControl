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

    public float dubaiAngle;

    public GameObject Marker;
    public GameObject Sun;

    public GameObject Earth;

    //public float OrbitSpeed = 10.0f;

    

    // Start is called before the first frame update
        void Start()
    {
        //transform.position = new Vector3(0, 1, 0);

        
        //Maker.transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (Earth.transform.position.z / Mathf.Abs(Earth.transform.position.z) >= 0)
        {
            dubaiAngle = -Vector3.Angle(Sun.transform.position, Marker.transform.position);
        }
        else 
        {
            dubaiAngle = Vector3.Angle(Sun.transform.position, Marker.transform.position);
        }
        Quaternion rotation = Quaternion.Euler(0, dubaiAngle, 0);
        transform.rotation = rotation;


        
        //transform.rotation.eulerAngle.y = Quaternion.eulerAngle(0, dubaiAngle, 0);

        //ScreenRotator.transform.Rotate(0, dubaiAngle, 0);

        //this.transform.eulerAngles = dubaiAngle;

        //timeCounter += Time.deltaTime * speed;

        //float x = Mathf.Cos(timeCounter) * width;
        //float z = Mathf.Sin(timeCounter) * height;

        //transform.RotateAround(Sun.transform.position, Vector3.up, OrbitSpeed/360);

        transform.position = new Vector3(0, -0.060f, 0);

       
        //if(originalX == trackPosition.transform.position.x && originalZ == track) 
        //{

        //}
    }


}

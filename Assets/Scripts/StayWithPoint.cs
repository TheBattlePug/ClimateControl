using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayWithPoint : MonoBehaviour
{
    public GameObject thingThatStaysInLine;
    public GameObject staying;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = staying.transform.position.x;

        float zValue = staying.transform.position.z;

        thingThatStaysInLine.transform.position = new Vector3(xValue, 0, zValue);
        
    }
}

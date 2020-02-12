using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSheet2 : MonoBehaviour
{
    public GameObject start;
    public GameObject end;

    public GameObject city;

    public Vector3 ray1;
    public Vector3 ray2;

    Ray roy;

    Quaternion quad;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray1 = end.transform.position - start.transform.position;

        ray2 = city.transform.position - start.transform.position;

        Debug.DrawRay(start.transform.position, ray1, Color.white);
        
        Debug.DrawRay(start.transform.position, ray2, Color.white);


        roy = new Ray();
        roy.origin = start.transform.position;

        roy.direction = ray1.normalized;
        

        transform.LookAt(end.transform);


       
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(roy);
    }
}

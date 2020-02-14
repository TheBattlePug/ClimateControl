using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeOpacity : MonoBehaviour
{

    public Renderer rend;
    public Material mat;

    public Slider mainSlider;

    public float value;
    
        
    void Start()
    {
        rend = GetComponent<Renderer>();

        value = 0.5f;   
    }
    
    public void Update()
    {
        //this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, mainSlider.value);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (value < 1.0f)
            {
                value += 0.1f;
                this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, value);
            }
            else
            {
                Debug.Log("The sheet is at the max opacity!");
            }
        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (value > 0.0f)
            {
                value -= 0.1f;
                this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, value);
            }
            else
            {
                Debug.Log("The sheet is at the minimum opacity!");
            }
        }








    }
}

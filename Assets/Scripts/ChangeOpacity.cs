using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeOpacity : MonoBehaviour
{

    public Renderer rend;
    public Material mat;

    public Slider mainSlider;
        
    void Start()
    {
        rend = GetComponent<Renderer>();

        
    }
    
    public void Update()
    {
        this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, mainSlider.value);
    }
}

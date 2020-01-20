using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera firstCamera;
    public Camera secondCamera;

    bool cam = true;
    

    // Start is called before the first frame update
    void Start()
    {
        //firstCameraAudio = firstCamera.getComponent<AudioListener>();
        //secondCameraAudio = secondCamera.getComponent<AudioListener>();
        // CameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cam = !cam;
           
        }

        firstCamera.gameObject.SetActive(cam);
        secondCamera.gameObject.SetActive(!cam);     
       
    }

  }
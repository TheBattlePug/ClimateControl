using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera firstCamera;
    public Camera secondCamera;
    public Camera thirdCamera;

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
        if (Input.GetButtonDown("Camera1"))
        {
            firstCamera.gameObject.SetActive(cam);
            secondCamera.gameObject.SetActive(!cam);
            thirdCamera.gameObject.SetActive(!cam);
        }

        if (Input.GetButtonDown("Camera2"))
        {
            firstCamera.gameObject.SetActive(!cam);
            secondCamera.gameObject.SetActive(cam);
            thirdCamera.gameObject.SetActive(!cam);
        }

        if (Input.GetButtonDown("Camera3"))
        {
            firstCamera.gameObject.SetActive(!cam);
            secondCamera.gameObject.SetActive(!cam);
            thirdCamera.gameObject.SetActive(cam);
        }
    }

  }
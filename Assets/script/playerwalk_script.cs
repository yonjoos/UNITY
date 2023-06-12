using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerwalk_script : MonoBehaviour
{
    float keyH = 0;
    float keyV = 0;
    float mouseX = 0;
    float mouseY = 0;

    GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        keyH = Input.GetAxis("Horizontal");
        keyV = Input.GetAxis("Vertical");
        keyH = keyH * 3.0f * Time.deltaTime;
        keyV = keyV * 3.0f * Time.deltaTime;

        transform.Translate(Vector3.forward *4* keyH);
        transform.Translate(Vector3.right * -4* keyV);


        mouseX = Input.GetAxis("Mouse X")*2;
        mouseY += Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.up * 2.0f * mouseX);
        //transform.Rotate(Vector3.left * 2.0f * mouseY);

        cam.transform.localRotation = Quaternion.Euler(-mouseY*3, 270, 0);
        
    }


}

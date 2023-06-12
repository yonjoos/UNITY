using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfoot_script : MonoBehaviour
{

    private bool sound = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            sound = true;
        }

        if (sound)
        {
            gameObject.GetComponent<AudioSource>().Play();
            sound = false;
        }
        
    }
}

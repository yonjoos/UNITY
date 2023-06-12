using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maincamera_srcipt : MonoBehaviour
{

    private Vector3 pos;
    

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(GameObject.Find("player").transform.position.x, 7, GameObject.Find("player").transform.position.z);
        transform.position = pos;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(GameObject.Find("player").transform.position.x + 5.3f, GameObject.Find("player").transform.position.y + 7, GameObject.Find("player").transform.position.z);

    }
}

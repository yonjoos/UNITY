using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tag_script2 : MonoBehaviour
{
    public bool caught;
    // Start is called before the first frame update
    void Start()
    {
        caught = false;
    }

    // Update is called once per frame
    void Update()
    {

        caught = GameObject.Find("plane").GetComponent<area_script>().caught;
        if (caught)
        {

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gamok_script : MonoBehaviour
{
    GameObject startline;
    //Animator ani;
    bool caught;
    bool start;
    bool up = false;
    bool down = false;
    // Start is called before the first frame update

    private int i = 0;

    void Start()
    {
        caught = false;
        start = false;
        startline = GameObject.Find("startline");
        //ani = gameObject.GetComponent<Animator>();
   


    }


    // Update is called once per frame
    void Update()
    {

        caught = GameObject.Find("Plane").GetComponent<area_script>().caught;
        if (caught)
        {
            GameObject.Find("gamok_down").SetActive(true);
        }


        else if(down == true)
        {
            GameObject.Find("gamok").SetActive(false);
        }
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(84, 60, -41), 3f);
    }


}

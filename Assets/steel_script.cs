using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steel_script : MonoBehaviour
{

    public AudioClip aud;
    public bool caught;
    public bool check;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator steelSound()
    {

        yield return new WaitForSeconds(2);

        GetComponent<AudioSource>().clip = aud;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().volume -= 0.1f*Time.deltaTime;



    }


    // Update is called once per frame
    void Update()
    {
        caught = GameObject.Find("Plane").GetComponent<area_script>().caught;
        check = GameObject.Find("Noface").GetComponent<noface_script2>().check;

        if (caught && check)
        {
            StartCoroutine(steelSound());

        }
    }
}

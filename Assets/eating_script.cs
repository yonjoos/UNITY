using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class eating_script : MonoBehaviour
{
    public AudioClip eat;
    public bool caught;
    public bool check;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    IEnumerator EatingSound ()
    {
        
        yield return new WaitForSeconds(5);

        GetComponent<AudioSource>().clip = eat;
        GetComponent<AudioSource>().Play();

        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(2);
    }
    // Update is called once per frame
    void Update()
    {

        caught = GameObject.Find("Plane").GetComponent<area_script>().caught;
        check = GameObject.Find("Noface").GetComponent<noface_script2>().check;

        if (caught && check)
        {
            StartCoroutine(EatingSound());
            
        }
    }
}

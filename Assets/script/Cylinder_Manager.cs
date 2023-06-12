using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder_Manager : MonoBehaviour
{
    public Animator at;
    public Animator at2;

    public GameObject[] caution;
    int i = 0;
    bool syl = true;

    // Start is called before the first frame update
    void Start()
    {
        at = gameObject.GetComponent<Animator>();
        StartCoroutine("push_back");
    }


    void push(Animator animator, int k)
    {
        animator.SetInteger("cyl"+k, k);
        
    }

    IEnumerator push_back()
    {

    
            i = Random.Range(0, 4);

            at = caution[i].GetComponent<Animator>();

            //Vector3 last_pos = new Vector3(caution[i].transform.position.x, caution[i].transform.position.y, caution[i].transform.position.z - 10);
            //Vector3 first_pos = caution[i].transform.position;


            push(at, i);


            yield return new WaitForSeconds(10.0f);
       
    }

    //IEnumerator push_back2()
    //{
        
    //        int i2 = Random.Range(0, 4);
    //        at2 = caution[i2].GetComponent<Animator>();
    //        push(at2, i2);

    //        yield return new WaitForSeconds(100.0f);
        
    //}


    // Update is called once per frame
    void Update()
    {
        
        //push_back();
        //push_back2();
     
        
        
    }
}

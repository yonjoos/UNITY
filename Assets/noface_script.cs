using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noface_script : MonoBehaviour
{
    public GameObject player;
    public Animator noface;


    bool k = false;


    public float x = 0;
    public float y = 0;


    // Start is called before the first frame update
    void Start()
    {
        noface = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()

    {



        /* *********
         ***********
         * ********
         *
         * noface가 한번 뒤돌아 본 이후로, player가 area랑 collision 했을 때(area랑 collision 안했으면 안쫓아옴) player를 쫓아오게 하도록 하고싶음. 안됨.


         ***********/






        //x = Input.GetAxis("Horizontal2");
        //y = Input.GetAxis("Vertical2");

        //Debug.Log(Mathf.Abs(player.transform.position.z - transform.position.z));

        //if (Mathf.Abs(player.transform.position.z - transform.position.z) <= 1.0f)
        //{
        //    Debug.Log("almost there!");
        //    x = 0;
        //}
        //else
        //{
        //    Debug.Log("way to go.");
        //    if (player.transform.position.z > transform.position.z) //플레이어의 위치가 가오나시의 위치보다 오른쪽에 있다면
        //    {
        //        x = 0.1f;
        //    }
        //    else if (player.transform.position.z < transform.position.z)
        //    {
        //        x = -0.1f;
        //    }
        //}

        //Debug.Log(Mathf.Abs(player.transform.position.x - transform.position.x));

        //if (Mathf.Abs(player.transform.position.x - transform.position.x) <= 1.0f)
        //{
        //    y = 0;
        //}
        //else {

        //    if (player.transform.position.x > transform.position.x)
        //    {
        //        y = 0.1f;
        //    }
        //    else if (player.transform.position.x < transform.position.x)
        //    {
        //        y = -0.1f;
        //    }
        //}

        //transform.Translate(Vector3.forward * 1 * x);
        //transform.Translate(Vector3.right * 1 * y);



    }
}

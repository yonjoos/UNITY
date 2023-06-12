using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown_script : MonoBehaviour
{
    public float i = 8;
    public Text cntdwn;

    public bool started;
    public bool gaofront;

    public GameObject gam;
    
    // Start is called before the first frame update
    void Start()
    {

        gam = GameObject.Find("gamok_start");
        cntdwn = GetComponent<Text>();
        cntdwn.text = "Ready";
        started = false;
        StartCoroutine(Ready());

        

    }

    IEnumerator Ready()
    {
        yield return new WaitForSeconds(3);
        cntdwn.text = "Start";
        //gam.transform.position = Vector3.MoveTowards(transform.position, new Vector3(84, 60, -41), 3f);
    }

    private void CountDown(bool gaoFront, bool _started)
    {
        if (_started)
        {
            //뒤돌아있을때
            if (gaoFront == false)
            {
                if (i > 0) i -= Time.deltaTime;
                else i = 8;
                cntdwn.color = Color.white;
                cntdwn.text = string.Format("{0:N0}", i);
            }

            //앞에 보고 있을땐느 빨간글씨
            else 
            {
                if (i > 0) i -= Time.deltaTime;
                else i = 8;
                cntdwn.color = Color.red;
                cntdwn.text = string.Format("{0:N0}", i);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        gaofront = GameObject.Find("Noface").GetComponent<noface_script2>().gaoFront;
        started = GameObject.Find("Noface").GetComponent<noface_script2>().game_start; 
        CountDown(gaofront, started);
   
    }
}

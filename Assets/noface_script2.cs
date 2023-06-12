using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class noface_script2 : MonoBehaviour
{

    public bool game_start = false;
    public bool cntstart = false;
    public bool gaoFront;
    public bool check;

    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        gaoFront = true;
        check = false;
        StartCoroutine(StartGame());
        player = GameObject.Find("player");
        
        
    }

    //게임 시작하고 3초 후 뒤집어
    IEnumerator StartGame()
    {

        Debug.Log("sibal");

        gaoFront = false;
        yield return new WaitForSeconds(4);

        //게임 시작 true;
        game_start = true;
        //뒤돌아

        transform.eulerAngles = new Vector3(0, 180, 0);
        
        game_start = true;
        //뒤돌자마자 카운트다운 시작!
        yield return StartCoroutine(NofaceWait());
        Debug.Log("jotgat");

    }

    //뒤돌아서 기다렿
    IEnumerator NofaceWait()
    {
        Debug.Log("hello");

        //countdown_script에 있는 countdown함수 호
        //GameObject.Find("Second").GetComponent<countdown_script>().SendMessage("CountDown");
        
        cntstart = true;
        yield return new WaitForSeconds(8);

        //다시 프론트로 뒤집어
        transform.eulerAngles = new Vector3(0, 0, 0);
        yield return StartCoroutine(NofaceCheck());
    }

    //다시 뒤 도는 함수
    //IEnumerator Nofaceback()
    //{
    //    Debug.Log("hello");

    //    //countdown_script에 있는 countdown함수 호
    //    //GameObject.Find("Second").GetComponent<countdown_script>().SendMessage("CountDown")

    //    check = false;
    //    //다시 프론트로 뒤집어
    //    transform.eulerAngles = new Vector3(0, 180, 0);
    //    yield return StartCoroutine(NofaceCheck());
    //}


    //움직이면 안되는 구간
    IEnumerator NofaceCheck()
    {
        gaoFront = true;
        check = true;
        yield return new WaitForSeconds(8);
        gaoFront = false;
        check = false;
        transform.eulerAngles = new Vector3(0, 180, 0);
        yield return StartCoroutine(NofaceWait());
        //transform.eulerAngles = new Vector3(0, 180, 0);

    }

    //IEnumerator happyending()
    //{
    //    yield return new WaitForSeconds(3);
    //    GameObject.Find("white").GetComponent<Animator>().SetTrigger("timetogo");
    //    SceneManager.LoadScene(2);
    //}

    // Update is called once per frame

    IEnumerator TTGO()
    {
        GameObject.Find("white").GetComponent<Animator>().SetTrigger("timetogo");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(3);
        yield return new WaitForSeconds(5);
        Application.Quit();
    }

    void Update()
    {

        //Debug.Log(""+Vector3.Distance(player.transform.position, transform.position));
        if (Vector3.Distance(player.transform.position, transform.position) <= 14f)
        {
            Debug.Log("시발개좆같아미친진짜");
            //Debug.Log(Vector3.Distance(player.transform.position, transform.position))
            StartCoroutine(TTGO());
            
        }
    }
}

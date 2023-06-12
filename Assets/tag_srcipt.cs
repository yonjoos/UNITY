using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tag_srcipt : MonoBehaviour
{
    public GameObject noface;
    public GameObject player;
    public GameObject gamok;
    //GameObject area;

    public Animator no_ani; //noface에 설정된 애니메이션(시간에 맞춰 뒤돌기)
    public float time = 0; //naface가 7초마다 뒤돌아보게하고싶은데 그게 잘 안됨

    public int flag = 0;
    public bool but;

    bool TTrun = false; //player가 도망가야함을 알려줌 TTrun이 true 가 되면 도망가야함




    
    void Start()
    {
        //noface = GameObject.Find("Noface");
        //player = GameObject.Find("player");
        //area = GameObject.Find("Plane");

        no_ani = noface.GetComponent<Animator>();
        gamok = GameObject.Find("gamok");

        no_ani.SetTrigger("gao_flip");
        noface.transform.position = new Vector3(-98.53f, 5.3f, 0);
        but = true;
    }



    //만약 플레이어가 지정된 영역(area->plane)이랑 접촉시에 TTrun(time to run) = true;
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (flag)
    //    {
    //        if (collision.gameObject.name == "player")
    //        {
    //            TTrun = true;
    //        }
    //    }
    //}



    //Update is called once per frames
    void Update()
    {

        //time += Time.deltaTime;

        no_ani.SetTrigger("gao_trigger"); //시작과 동시에 noface가 뒤를돌아봄(무궁화꽃이 피었습니다 게임 시작)
        GameObject.Find("gamok (1)").SetActive(true);//(두번째 감옥 만들기))

        if (no_ani.GetCurrentAnimatorStateInfo(0).IsName("flip_back"))//noface가 뒤돌아볼 때는 자유롭게 area 돌아다닐 수 있음..근데 어케 해야할지 모르겠음
        {

        }

        if (player.transform.position.z >= -31 && player.transform.position.z <= 31 && but && player.transform.position.x <= 80) //위에 if문으로 area를 어떻게 다뤄야할지 몰라서 z축의 위치로 조절함
        {
            no_ani.SetTrigger("gao_chase");// -31 <= z <= 31일떄 Noface가 쫓아옴

            flag++;//맨 처음에 시작할 때부터 쫓아오면 안되니까 적어도 noface가 한번 뒤돌아본 후에 area와의 Collision체크를 하겠다. line44참고.
            but = false;

            //GameObject.Find("gamok (1)").transform.position = Vector3.MoveTowards(transform.position, new Vector3(84, 1, -41), 3f);
        }

        GameObject.Find("gamok (1)").transform.position = Vector3.MoveTowards(GameObject.Find("gamok (1)").transform.position, new Vector3(84, 1, -41), 3f);
        //noface가 쫓아오기 시작하면 감옥 문 밑으로 내려오게



        //noface가 쫓아오는(gaonishi_walk)애니메이션이 시작될 때, 감옥 문이 내려오기 시작했으면 좋겠어서 어디에서 본 코드를 따라했는데 했는데 잘 안됨ㅠㅠ
        IEnumerator CheckAnimationState()
        {

            while (!no_ani.GetCurrentAnimatorStateInfo(0)
            .IsName("gaonashi_walk"))
            {
                //전환 중일 때 실행되는 부분
                yield return null;
            }

            while (no_ani.GetCurrentAnimatorStateInfo(0)
            .normalizedTime < 11.0f)
            {
                //애니메이션 재생 중 실행되는 부분
                yield return null;
            }

            GameObject.Find("gamok (1)").transform.position = Vector3.MoveTowards(GameObject.Find("gamok (1)").transform.position, new Vector3(84, 1, -41), 2f*Time.deltaTime);
            gameObject.GetComponent<AudioSource>().Play();

            //SceneManager.LoadScene(1);

        }

       

        StartCoroutine(CheckAnimationState());





        //IEnumerator Chase()
        //{

        //    while (but)
        //    {
        //        //전환 중일 때 실행되는 부분
        //        yield return null;
        //    }

        //    while (but)
        //    {
        //        //애니메이션 재생 중 실행되는 부분
        //        yield return null;
        //    }

        //    GameObject.Find("gamok (1)").transform.position = Vector3.MoveTowards(GameObject.Find("gamok (1)").transform.position, new Vector3(84, 1, -41), 2f * Time.deltaTime);

        //}



        //StartCoroutine(CheckAnimationState());



    }
}

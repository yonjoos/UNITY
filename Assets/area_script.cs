using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class area_script : MonoBehaviour
{
    public GameObject player;
    public GameObject noface;
    public bool collision_check;
    public bool caught;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        noface = GameObject.Find("Noface");
        collision_check = false;
        caught = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision_check)
        { 
            if(collision.gameObject.name == "player")
            {
                //caught = true;
            }
        }
    }

    private bool AreaCheck (GameObject _player)
    {
        if ((_player.transform.position.x >= -80 && _player.transform.position.x <= 84))
        {
            if (_player.transform.position.z >= -40 && _player.transform.position.z <= 40)
            {
                return true;
            }
            else return false;
        }
        else
            return false;
    }


    // Update is called once per frame
    void Update()
    {
        collision_check = GameObject.Find("Noface").GetComponent<noface_script2>().check;
        caught = AreaCheck(player);



        if (caught == true &&collision_check)
        {
            GameObject.Find("gamok_end").GetComponent<Animator>().SetTrigger("caught");
            IEnumerator nofacebye()
            {
                yield return new WaitForSeconds(2);
                noface.SetActive(false);
                //GameObject.Find("gamok_end").GetComponent<Animator>().SetTrigger("fuckyou");
                GameObject.Find("Second").GetComponent<Text>().fontSize += 20;
                GameObject.Find("Second").GetComponent<Text>().text = "?";
                yield return new WaitForSeconds(3);
                GameObject.Find("Second").GetComponent<Text>().text = "";
                GameObject.Find("Image").GetComponent<Animator>().SetTrigger("caught");
                //yield return new WaitForSeconds(4.3f);
                //GameObject.Find("Audio Source").GetComponent<AudioSource>().Play();
            }
            StartCoroutine(nofacebye());
            
        }
    }
}

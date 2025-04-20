using System.Collections;
using UnityEngine;
using Fungus;
using System;

public class C0_Player : MonoBehaviour
{
    public GameObject P1,Book;
    private Animator aniUI;
    private Boolean B = false;
    private SE SE;

    void Start()
    {
        aniUI = GameObject.Find("新手教學用").GetComponent<Animator>();
        SE = GameObject.Find("SE").GetComponent<SE>();
    }

    void OnCollisionEnter2D(UnityEngine.Collision2D coll)
    {
        if (coll.gameObject.name == "落石處")
        {
            if (B == true)
            {
                Flowchart.BroadcastFungusMessage("落石處");
                Destroy(coll.gameObject);
            }
            else
            {
                transform.position += new Vector3(-0.5f, 0, 0);
                Flowchart.BroadcastFungusMessage("未撿起");
            }
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "提示1")
        {
            StartCoroutine(提示1());
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.name == "史萊姆回血處")
        {
            Flowchart.BroadcastFungusMessage("史萊姆回血處");
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.name == "撿到礦工手冊")
        {
            Flowchart.BroadcastFungusMessage("撿到礦工手冊");
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.name == "礦工手冊")
        {
            B = true;
            Book.SetActive(true);
            Flowchart.BroadcastFungusMessage("獲得礦工手冊");
            Destroy(coll.gameObject);
        }
    }

    IEnumerator 提示1()
    {
        aniUI.Play("提示01");
        yield return new WaitForSeconds(1);
        P1.SetActive(false);
    }
}

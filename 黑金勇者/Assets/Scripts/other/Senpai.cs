using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Senpai : MonoBehaviour
{
    private Achievement SA;

    void Start()
    {
        SA = GameObject.Find("GM").GetComponent<Achievement>();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "十字鎬")
        {
            SA.Violent();
            Flowchart.BroadcastFungusMessage("痛毆前輩");
        }
    }
}

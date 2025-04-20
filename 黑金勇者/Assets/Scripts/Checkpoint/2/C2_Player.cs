using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class C2_Player : MonoBehaviour
{
    public bool Senpai;
    private Bag GM;

    void Start()
    {
        GM = GameObject.Find("Canvas").GetComponent<Bag>();
    }
    void OnCollisionEnter2D(UnityEngine.Collision2D coll)
    {
        if (coll.gameObject.name == "找礦車")
        {
            Flowchart.BroadcastFungusMessage("找礦車");
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "前輩離去")
        {
            if (GM.ore >= 20)
            {
                Flowchart.BroadcastFungusMessage("前輩離去");
                GM.ore = 0;
                Destroy(coll.gameObject);
            }
        }
    }
}

using UnityEngine;
using Fungus;
using System;

public class C0 : MonoBehaviour
{
    private GM GM;
    private Bag BB;
    public Boolean F1 = false;

    void Start()
    {
        GM = GameObject.Find("GM").GetComponent<GM>();
        BB = GameObject.Find("Canvas").GetComponent<Bag>();
        F1 = false;
    }

    void Update()
    {
        if (F1 == true)
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                回復血量後();
            }
        }
    }

        public void CBread()
    {
        if (F1 == true)
        {
            回復血量後();
        }
        else 
        {
            BB.Bread();
        }
    }

    public void 回復血量後()
    {
        Flowchart.BroadcastFungusMessage("回復血量後");
        F1 = false;
        BB.Bread();
    }


    public void controlsT()
    {
        GM.controls = true;
    }
    public void controlsF()
    {
        GM.controls = false;
    }

    public void C1BookT()
    {
        BB.C1Book = true;
    }
    public void C1BookF()
    {
        BB.C1Book = false;
    }
}

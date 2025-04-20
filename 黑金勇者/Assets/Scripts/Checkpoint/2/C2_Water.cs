using UnityEngine;
using Fungus;

public class C2_Water : MonoBehaviour
{
    public bool W;
    private Bag GM;
    private SE SE;

    void Start()
    {
        W = false;
        GM = GameObject.Find("Canvas").GetComponent<Bag>();
        SE = GameObject.Find("SE").GetComponent<SE>();
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "事件礦石(Clone)" && GM.ore >= 10)
        {
            SE.PLAYrock();
            Flowchart.BroadcastFungusMessage("水");
            W = true;
            Destroy(coll.gameObject,1f);
        }
        
        if (coll.gameObject.name == "按鈕_抽水機")
        {
            SE.PLAYbutton();
            if (W == true)
            {  
                Flowchart.BroadcastFungusMessage("抽水");
                W = false;
            }
    
        }
    }
}

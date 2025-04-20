using UnityEngine;
using Fungus;

public class C1_Player : MonoBehaviour
{
    private Bag GM;
    private C1_Button C1;

    void Start()
    {
        GM = GameObject.Find("Canvas").GetComponent<Bag>();
        C1 = GameObject.Find("按鈕").GetComponent<C1_Button>();
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "結尾")
        {
            if (GM.ore >= 10 && C1.E == true)
            {
                Flowchart.BroadcastFungusMessage("結尾");
            }
        }
    }
}

using UnityEngine;
using Fungus;

public class C1_Button : MonoBehaviour
{
    public Animator AniEvent;
    public bool E,EO;
    private SE SE;
    private float 可啟動, 電梯啟動時間=4.5f;

    void Start()
    {
        E = false;
        EO = false;
        SE = GameObject.Find("SE").GetComponent<SE>();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "十字鎬")
        {
            SE.PLAYbutton();
            if (E == false)
            {
                Flowchart.BroadcastFungusMessage("前輩上電梯");
                E = true;
            }
            if (E == true && EO == true)
            {
                if (Time.time >= 可啟動)
                {
                    AniEvent.Play("電梯(下樓)");
                    EO = false;
                    可啟動 = Time.time + 電梯啟動時間;
                }
            }
            if (E == true && EO == false)
            {
                if (Time.time >= 可啟動)
                {
                    AniEvent.Play("電梯(上樓)");
                    EO = true;
                    可啟動 = Time.time + 電梯啟動時間;
                }
            }
        }
    }
}

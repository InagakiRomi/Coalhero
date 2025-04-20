using System.Collections;
using UnityEngine;
using Fungus;

public class C3_GM : MonoBehaviour
{
    public bool CM;
    public float 停止中毒 = 10;
    private float 中毒;
    private Player PHP;
    public 關卡音效 CSE;
    private SE SE;
    private BGM BGM;

    void Start()
    {
        PHP = GameObject.Find("主角").GetComponent<Player>();
        SE = GameObject.Find("SE").GetComponent<SE>();
        BGM = GameObject.Find("BGM").GetComponent<BGM>();
    }
    void Update()
    {
        if (CM == true)
        {
            if (Time.time >= 中毒)
            {
                StartCoroutine(一氧化碳());
                中毒 = Time.time + 停止中毒;
            }
        }
    }

    public void CMT()
    {
        CM = true;
        PHP.C3Walk = true;
        BGM.PLAYC3CM();

    }

    public void 戴上呼吸器()
    {
        PHP.C3Walk = false;
    }

    public void 呼吸器()
    {
        if (PHP.C3Walk == false)
        {
            CSE.PLAYs1();
            Flowchart.BroadcastFungusMessage("戴上呼吸器");
        }
    }

    IEnumerator 一氧化碳()
    {
        yield return new WaitForSeconds(停止中毒);
        SE.PLAYdu();
        PHP.受傷(1);
    }
}

using UnityEngine;
using Fungus;

public class C0_Slime : MonoBehaviour
{
    private GameObject player;
    private MosterHP MHP;
    private C0 CGM;

    private SpriteRenderer SR;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        CGM = GameObject.Find("GM").GetComponent<C0>();
        SR = GetComponent<SpriteRenderer>();
        MHP = GetComponent<MosterHP>();
    }

    void FixedUpdate()
    {
        if (player != null)
        {
            SR.flipX = player.transform.position.x < transform.position.x;
        }
        if (MHP.HP <= 0)
        {
            CGM.F1 = true;
            Flowchart.BroadcastFungusMessage("史萊姆死亡後");
            Destroy(gameObject);
        }
    }
}

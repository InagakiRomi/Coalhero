using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public Sprite[] RockS;
    public SpriteRenderer SR;
    public int HitCount;
    public GameObject ore;
    private SE SE;
    public GameObject PS1;//特效
    private Achievement SA;

    void Start()
    {
        SE = GameObject.Find("SE").GetComponent<SE>();
        SA = GameObject.Find("GM").GetComponent<Achievement>();
        HitCount = -1;
    }

    void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.tag == "十字鎬"){
            HitCount++;
            SE.PLAYrock();
            SA.Miner();
            if (HitCount <= 1){
                SR.sprite = RockS[HitCount];
                Instantiate(PS1, transform.position, transform.rotation);
            }
            if (HitCount == 2){
                Instantiate(ore, transform.position, transform.rotation);
                Destroy(gameObject);
                Instantiate(PS1, transform.position, transform.rotation);
            }
        }
    }
}

using System.Collections;
using UnityEngine;
using Fungus;

public class C3_Poison : MonoBehaviour
{
    public GameObject ore;

    private GameObject Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("十字鎬");
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "事件礦石(Clone)" || ore.transform.childCount <= 1 && coll.gameObject.tag == "ROCK")
        {
            Player.GetComponent<PolygonCollider2D>().enabled = false;
            Flowchart.BroadcastFungusMessage("毒氣");
            Destroy(ore.gameObject);
        }
    }
}

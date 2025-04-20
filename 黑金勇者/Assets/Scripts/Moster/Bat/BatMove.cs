using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMove : MonoBehaviour
{
    public GameObject Bat,box;
    public Bat BS;
    public float 重生時間;

    void Update()
    {
        if (box.transform.childCount < 1)
        {
            Destroy(gameObject, 重生時間);
        }
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            BS.Walk = true;
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            BS.Walk = false;
        }
    }
}

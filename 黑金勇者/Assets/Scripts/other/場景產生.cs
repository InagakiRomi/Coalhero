using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 場景產生 : MonoBehaviour
{
    public GameObject box;
    public GameObject[] obs;

    public enum ItemTypeList
    {
        ore,box,
    }
    public ItemTypeList type;

    void Start()
    {
        物件再生();
    }


    void Update()
    {
        if (type == ItemTypeList.box)
        {
            if (box.transform.childCount < 1)
            {
                物件再生();
            }
        }
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.transform.tag == "Box")
        {
            Destroy(coll.gameObject);
        }
    }

    void 物件再生()
    {
        int i = Random.Range(0, obs.Length);
        GameObject m = Instantiate(obs[i], transform.position, Quaternion.identity);
        m.transform.parent = box.transform;
    }
}

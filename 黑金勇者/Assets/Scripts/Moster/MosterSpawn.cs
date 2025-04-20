using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosterSpawn : MonoBehaviour
{
    public GameObject box;
    public GameObject Moster;
    public GameObject[] 產出點;

    void Update()
    {
        if (box.transform.childCount < 1)
        {
            Transform tr = 產出點[Random.Range(0, 產出點.Length)].transform;
            GameObject m = Instantiate(Moster, tr.position, tr.rotation);
            m.transform.parent = box.transform;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteOutline : MonoBehaviour
{
    private GameObject player;
    public Material[] mats;
    public SpriteRenderer SR;
    public float 判定距離 = 2.5f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player != null)
        {
            float 兩者距離 = Vector3.Distance(transform.position, player.transform.position);
            if (兩者距離 >= 判定距離)
            {
                SR.material = mats[0];
            }
            else
            {
                SR.material = mats[1];
            }
        }
    }
}

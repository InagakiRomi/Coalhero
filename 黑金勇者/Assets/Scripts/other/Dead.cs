using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public float 消失時間;
    void Start()
    {
        Destroy(gameObject, 消失時間);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

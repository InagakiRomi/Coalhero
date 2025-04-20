using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCA : MonoBehaviour
{
    private Achievement SA;
    public bool God;

    void Start()
    {
        SA = GameObject.Find("GM").GetComponent<Achievement>();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (gameObject.name == "Elevator")
            {
                SA.Elevator();
            }
            if (gameObject.name == "Supply")
            {
                SA.Supply();
            }
            if (God == true)
            {
                if (gameObject.name == "GodFavor")
                {
                    SA.GodFavor();
                }
            }
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "十字鎬")
        {
            if (gameObject.name == "Cruel")
            {
                SA.Cruel();
            }
            if (gameObject.name == "Secret")
            {
                SA.Secret();
            }
        }
    }

    public void GodKnow()
    {
        God = false;
    }
}
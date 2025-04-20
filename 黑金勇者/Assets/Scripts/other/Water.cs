using UnityEngine;

public class Water : MonoBehaviour
{
    public GameObject s;
    private SE2 SE2;

    void Start()
    {
        SE2 = GameObject.Find("SE2").GetComponent<SE2>();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            coll.gameObject.transform.position = s.transform.position;
            SE2.PLAYwater();
        }
    }
}

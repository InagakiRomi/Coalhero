using UnityEngine;

public class BatDead : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2);
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "地板")
        {
            gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }

    }
}

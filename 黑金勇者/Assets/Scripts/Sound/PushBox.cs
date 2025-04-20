using UnityEngine;

public class PushBox : MonoBehaviour
{
    private SELoop SEL;

    void Start()
    {
        SEL = GameObject.Find("SELoop").GetComponent<SELoop>();
        //if (gameObject.transform.position.x ++)
    }

    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.layer == 8)
        {
            /*
                if ()
                {
                    SEL.PLAYbox();
                }
                else
                {
                    SEL.P空();
                }
            */
        }
    }
}

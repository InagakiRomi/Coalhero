using UnityEngine;

public class Moss : MonoBehaviour
{
    private Player PHP;
    private SE SE;
    bool ff = false;
    float 滑行時間 = 2;

    void Start()
    {
        PHP = GameObject.Find("主角").GetComponent<Player>();
        SE = GameObject.Find("SE").GetComponent<SE>();
    }
    void FixedUpdate()
    {
        if (ff==true){
            float s = 0;
            while (s < 滑行時間)
            {
                if (PHP.transform.localScale.x < 0)
                {
                    PHP.transform.position += new Vector3(-0.1f, 0, 0);
                }
                else
                {
                    PHP.transform.position += new Vector3(0.1f, 0, 0);
                }
                s++;
            }
            ff = false;
        }
    }
    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            ff = true;
        }
    }

}

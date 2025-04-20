using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C3_Rocks : MonoBehaviour
{
    public GameObject PS1;
    private Player PHP;
    private SE SE;

    public enum ItemTypeList
    {
        BRock, SRock
    }
    public ItemTypeList type;
    private Achievement SA;
    void Start()
    {
        PHP = GameObject.Find("主角").GetComponent<Player>();
        SE = GameObject.Find("SE").GetComponent<SE>();
        SA = GameObject.Find("GM").GetComponent<Achievement>();
    }
    void OnTriggerEnter2D(Collider2D coll){
        if (type == ItemTypeList.BRock)
        {
            if (coll.gameObject.tag == "Player")
            {
                PHP.受傷(1);
                SE.PLAYdu();
                SA.Helmet();
            }
        }
        if (coll.gameObject.tag == "DEADZONE"){
            Destroy(gameObject);
        }
        if (coll.gameObject.layer == 8)
        {
            Instantiate(PS1, transform.position, transform.rotation);
        }
    }
}

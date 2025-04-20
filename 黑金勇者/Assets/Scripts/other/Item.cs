using System.Collections;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemTypeList
    {
        Ifood,Iwater,Iore
    }
    public ItemTypeList type;
    private Achievement SA;
    private Bag GM;
    private SE SE;


    void Start(){

        SA = GameObject.Find("GM").GetComponent<Achievement>();
        GM = GameObject.Find("Canvas").GetComponent<Bag>();
        SE = GameObject.Find("SE").GetComponent<SE>();
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(3.0f, 6.0f, 0.0f);
        StartCoroutine(碰撞());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            if(type == ItemTypeList.Ifood)
            {
                GM.bread += 1;
            }
            if (type == ItemTypeList.Iwater)
            {
                GM.water += 1;
            }
            if (type == ItemTypeList.Iore)
            {
                GM.ore += 1;
                if (GM.ore == 10)
                {
                    SA.Novice();
                }
                else if (GM.ore == 20)
                {
                    SA.Person();
                }
            }
            SE.PLAYget();
            Destroy(gameObject);
        }
    }

    IEnumerator 碰撞()
    {
        yield return new WaitForSeconds(0.8f);
        this.GetComponent<CircleCollider2D>().enabled = true;
    }
}

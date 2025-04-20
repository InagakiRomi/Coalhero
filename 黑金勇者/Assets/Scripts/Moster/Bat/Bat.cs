using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    private GameObject player;
    private MosterHP MHP;

    public Sprite SS;
    public GameObject B,D;

    public float 移動速度, 攻擊間隔時間, 判定距離;

    public bool Walk,Attack;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        MHP = GetComponent<MosterHP>();
        Walk = false;
        Attack = true;
    }

    void Update()
    {
        if (player != null)
        {
            if (MHP.HP > 0)
            {
                if (Walk == true)
                {
                    if(Attack == true)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, 移動速度);
                    }
                    else
                    {
                        float 兩者距離 = Vector3.Distance(transform.position, player.transform.position);
                        if (兩者距離 >= 判定距離)
                        {
                            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, 移動速度);
                        }
                    }
                }
                else
                {
                    transform.position = Vector2.MoveTowards(transform.position, B.transform.position, 移動速度);
                }
            }
        }
        if (MHP.HP <= 0)
        {
            Instantiate(D, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            StartCoroutine(攻擊());
        }
    }

    IEnumerator 攻擊()
    {
        Attack = false;
        yield return new WaitForSeconds(攻擊間隔時間);
        Attack = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    private GameObject player;
    private SpriteRenderer SR;
    private Rigidbody2D rb;
    private MosterHP MHP;
    public GameObject S;
    public Sprite SS;

    public float 移動速度;
    public float 停止前進距離;
    public float 攻擊間隔時間;
    private float 可攻擊時間;
    public float 重生時間;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        SR = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        MHP = GetComponent<MosterHP>();
    }
    void FixedUpdate()
    {
        if (player != null)
        {
            float 兩者距離 = Vector2.Distance(transform.position, player.transform.position);
            if (MHP.HP > 0)
            {
                SR.flipX = player.transform.position.x < transform.position.x;
                if (兩者距離 > 停止前進距離)
                {
                    transform.position = Vector2.MoveTowards(transform.position, player.transform.position, 移動速度);
                }
            }
            else
            {
                if (Time.time >= 可攻擊時間)
                {
                    StartCoroutine(攻擊());
                    可攻擊時間 = Time.time + 攻擊間隔時間;
                }
            }
        }
        if (MHP.HP <= 0)
        {
            StartCoroutine(死亡());
        }
    }

    IEnumerator 攻擊()
    {
        yield return new WaitForSeconds(1.5f);
        Vector3 現在位置 = transform.position;
        float percent = 0;
        while (percent <= 1)
        {
            percent += Time.deltaTime + 移動速度;
            float formula = (-Mathf.Pow(percent, 2) + percent) * 4;
            if (MHP.HP > 0)
            {
                if (SR.flipX != true)
                {
                    transform.position = Vector3.Lerp(現在位置, 現在位置 + new Vector3(2, 0, 0), formula);
                }
                else
                {
                    transform.position = Vector3.Lerp(現在位置, 現在位置 + new Vector3(-2, 0, 0), formula);
                }
            }
            yield return null;
        }
    }
    IEnumerator 死亡()
    {
        SR.sprite = SS;
        rb.simulated = false;
        gameObject.GetComponent<Animator>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(2f);
        S.SetActive(false);
        Destroy(gameObject, 重生時間);
    }
}

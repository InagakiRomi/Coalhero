using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public GameObject[] page, Mine, Miner;
    public GameObject Previous, Next, Exit;
    public int Score;
    private SE SE;

    void Start()
    {
        SE = GameObject.Find("SE").GetComponent<SE>();
    }
    void Update()
    {
        if(Score == 1)
        {
            Previous.SetActive(false);
        }
        else
        {
            Previous.SetActive(true);
        }

        if (Score == 11)
        {
            Next.SetActive(false);
            Exit.SetActive(true);
        }
        else
        {
            Next.SetActive(true);
            Exit.SetActive(false);
        }

        if (Score >= 3)
        {
            Mine[0].SetActive(true);
            Mine[1].SetActive(true);
        }
        else
        {
            Mine[0].SetActive(false);
            Mine[1].SetActive(false);
        }

        if (Score >= 9)
        {
            Miner[0].SetActive(true);
            Miner[1].SetActive(true);
        }
        else
        {
            Miner[0].SetActive(false);
            Miner[1].SetActive(false);
        }
    }

    public void UP()
    {
        SE.PLAYbook();
        page[Score].SetActive(true);
        page[Score-1].SetActive(false);
        Score += 1;
    }

    public void Down()
    {
        SE.PLAYbook();
        Score -= 1;
        page[Score].SetActive(false);
        page[Score-1].SetActive(true);
    }
}

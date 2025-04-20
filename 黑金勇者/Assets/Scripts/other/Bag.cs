using System;
using UnityEngine;
using UnityEngine.UI;

public class Bag : MonoBehaviour
{
    public GameObject Backpack,Book, BagObject;
    public Text t1, t2, t3, t4;
    public int bread, water, ore;
    public Boolean C1Book;
    private Boolean BOpen = false;
    private Player PHP;
    private GM GM;
    private SE SE;

    void Start(){
        PHP = GameObject.Find("主角").GetComponent<Player>();
        GM = GameObject.Find("GM").GetComponent<GM>();
        SE = GameObject.Find("SE").GetComponent<SE>();
        C1Book = true;
    }

    void Update(){
        t1.text = bread.ToString();
        t2.text = water.ToString();
        t3.text = ore.ToString();
        t4.text = ore.ToString();

        if (GM.controls == false){
            Backpack.SetActive(false);
            BOpen = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Book.activeInHierarchy == true)
            {
                BBook();
            }
        }

        if (GM.controls == true)
        {
            if (BagObject.activeInHierarchy == true)
            {
                if (Input.GetKeyDown(KeyCode.O))
                {
                    Box();
                }
                if (Input.GetKeyDown(KeyCode.C))
                {
                    Water();
                }
                if (Input.GetKeyDown(KeyCode.V))
                {
                    Bread();
                }
                if(C1Book == true)
                {
                    if (Input.GetKeyDown(KeyCode.B))
                    {
                        BBook();
                    }
                }
            }
        }
    }

    public void Box(){
        if (GM.controls == true){
            if (BOpen == false)
            {
                Backpack.SetActive(true);
                BOpen = true;
            }
            else
            {
                Backpack.SetActive(false);
                BOpen = false;
            }
        }  
    }

    public void Bread(){
        if (bread > 0)
        {
            if (PHP.HP < 10)
            {
                PHP.補血(2);
                SE.PLAYeat();
                bread -= 1;
            }
        }
    }

    public void Water(){
        if (water > 0)
        {
            if (PHP.HP < 10)
            {
                PHP.補血(1);
                SE.PLAYeat();
                water -= 1;
            }
        }
    }
    public void BBook()
    {
        if (Book.activeInHierarchy == false)
        {
            Book.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Book.SetActive(false);
            Time.timeScale = 1;
        }
    }
}

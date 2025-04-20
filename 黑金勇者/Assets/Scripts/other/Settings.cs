using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    private Player PHP;
    private Bag BAG;

    void Start()
    {
        PHP = GameObject.Find("主角").GetComponent<Player>();
        BAG = GameObject.Find("Canvas").GetComponent<Bag>();

        GetFloat();
        string RestartSceneName = SceneManager.GetActiveScene().name;
        if (RestartSceneName == "0新手教學")
        {
            BagAndHPRestart();
        }
        OreZero();
        PHP.更新生命圖片(PHP.HP);
    }
    public void GetFloat()
    {
        PHP.HP = PlayerPrefs.GetInt("Player_HP", PHP.HP);
        BAG.bread = PlayerPrefs.GetInt("Bag_Bread", BAG.bread);
        BAG.water = PlayerPrefs.GetInt("Bag_Water", BAG.water);
        BAG.ore = PlayerPrefs.GetInt("Bag_Ore", BAG.ore);
    }
    public void SetFloat()
    {
        PlayerPrefs.SetInt("Player_HP", PHP.HP);
        PlayerPrefs.SetInt("Bag_Bread", BAG.bread);
        PlayerPrefs.SetInt("Bag_Water", BAG.water);
        PlayerPrefs.SetInt("Bag_Ore", BAG.ore);
    }
    public void BagAndHPRestart()
    {
        PHP.HP = 10;
        BAG.bread = 5;
        BAG.water = 10;

        string RestartSceneName = SceneManager.GetActiveScene().name;
        OreZero();
        if (RestartSceneName == "2第二關")
        {
            BAG.ore = 10;
        }
    }

    public void OreZero()
    {
        string RestartSceneName = SceneManager.GetActiveScene().name;
        if (RestartSceneName == "0新手教學" || RestartSceneName == "1第一關" || RestartSceneName == "3第三關")
        {
            BAG.ore = 0;
        }
    }
}

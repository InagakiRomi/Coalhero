using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class Achievement : MonoBehaviour
{
    public void Violent()
    {
        SteamUserStats.SetAchievement("Violent");
        SteamUserStats.StoreStats();
        print("暴力分子");
    }
    public void Miner()
    {
        SteamUserStats.SetAchievement("Miner");
        SteamUserStats.StoreStats();
        print("成為礦工");
    }
    public void WhoDropped()
    {
        SteamUserStats.SetAchievement("WhoDropped");
        SteamUserStats.StoreStats();
        print("誰掉了東西");
    }
    public void Respirator()
    {
        SteamUserStats.SetAchievement("Respirator");
        SteamUserStats.StoreStats();
        print("誰的……奶嘴？");
    }
    public void Novice()
    {
        SteamUserStats.SetAchievement("Novice");
        SteamUserStats.StoreStats();
        print("新手上路");
    }
    public void Person()
    {
        SteamUserStats.SetAchievement("Person");
        SteamUserStats.StoreStats();
        print("採礦達人");
    }
    public void Death()
    {
        SteamUserStats.SetAchievement("Death");
        SteamUserStats.StoreStats();
        print("死亡");
    }
    public void Elevator()
    {
        SteamUserStats.SetAchievement("Elevator");
        SteamUserStats.StoreStats();
        print("小心電梯");
    }
    public void Slime()
    {
        SteamUserStats.SetAchievement("Slime");
        SteamUserStats.StoreStats();
        print("小心史萊姆");
    }
    public void Bat()
    {
        SteamUserStats.SetAchievement("Bat");
        SteamUserStats.StoreStats();
        print("小心蝙蝠");
    }
    public void Helmet()
    {
        SteamUserStats.SetAchievement("Helmet");
        SteamUserStats.StoreStats();
        print("小心頭頂");
    }
    public void Secret()
    {
        SteamUserStats.SetAchievement("Secret");
        SteamUserStats.StoreStats();
        print("電梯的秘密");
    }
    public void GodFavor()
    {
        SteamUserStats.SetAchievement("GodFavor");
        SteamUserStats.StoreStats();
        print("天神眷顧");
    }
    public void Surprise()
    {
        SteamUserStats.SetAchievement("Surprise");
        SteamUserStats.StoreStats();
        print("驚喜");
    }
    public void Out()
    {
        SteamUserStats.SetAchievement("Out");
        SteamUserStats.StoreStats();
        print("出坑");
    }
    public void Dizziness()
    {
        SteamUserStats.SetAchievement("Dizziness");
        SteamUserStats.StoreStats();
        print("頭暈");
    }
    public void Cruel()
    {
        SteamUserStats.SetAchievement("Cruel");
        SteamUserStats.StoreStats();
        print("殘忍");
    }
    public void Supply()
    {
        SteamUserStats.SetAchievement("Supply");
        SteamUserStats.StoreStats();
        print("補給");
    }
    public void Rookie()
    {
        SteamUserStats.SetAchievement("Rookie");
        SteamUserStats.StoreStats();
        print("礦坑菜鳥");
    }
    public void Practice()
    {
        SteamUserStats.SetAchievement("Practice");
        SteamUserStats.StoreStats();
        print("熟能生巧");
    }
    public void Better()
    {
        SteamUserStats.SetAchievement("Better");
        SteamUserStats.StoreStats();
        print("漸入佳境");
    }
    public void Escape()
    {
        SteamUserStats.SetAchievement("Escape");
        SteamUserStats.StoreStats();
        print("死裡逃生");
    }
    public void NotDead()
    {
        SteamUserStats.SetAchievement("NotDead");
        SteamUserStats.StoreStats();
        print("大難不死");
    }
    public void Hero()
    {
        SteamUserStats.SetAchievement("Hero");
        SteamUserStats.StoreStats();
        print("黑金勇者");
    }
}

using System.Collections;
using UnityEngine;

public class GM : MonoBehaviour
{
    public bool controls;
    private GameObject Player, Pcamera, Mcamera;
    private Animator PlayerAni;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerAni = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        Pcamera = GameObject.FindGameObjectWithTag("PCamera");
        Mcamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    public void CancelControls(){
        controls = false;
        Mcamera.SetActive(true);

        PlayerAni.Play("待命");
        PlayerAni.SetTrigger("Say");
    }

    public void GiveBackControls(){
        controls = true;
        Mcamera.SetActive(false);
    }

    public void PlayerT()
    {
        Player.SetActive(true);
        Pcamera.SetActive(true);
    }
    public void PlayerF()
    {
        Player.SetActive(false);
        Pcamera.SetActive(false);
    }
}

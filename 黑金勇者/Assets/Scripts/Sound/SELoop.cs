using UnityEngine;

public class SELoop : MonoBehaviour
{
    public AudioClip 空, box;
    AudioSource audiosource;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    public void P空()
    {
        audiosource.clip = 空;
        audiosource.Play();
    }
    public void PLAYbox()
    {
        audiosource.clip = box;
        audiosource.Play();
    }
}
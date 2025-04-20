using UnityEngine;

public class SE2 : MonoBehaviour
{
    public AudioClip att,water ,board;
    AudioSource audiosource;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    public void PLAYatt()
    {
        audiosource.clip = att;
        audiosource.Play();
    }
    public void PLAYwater()
    {
        audiosource.clip = water;
        audiosource.Play();
    }
    public void PLAYboard()
    {
        audiosource.clip = board;
        audiosource.Play();
    }
}

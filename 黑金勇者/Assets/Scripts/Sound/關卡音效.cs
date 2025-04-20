using UnityEngine;

public class 關卡音效 : MonoBehaviour
{
    public AudioClip s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,s11,s12;
    AudioSource audiosource;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    public void PLAYs1()
    {
        audiosource.clip = s1;
        audiosource.Play();
    }
    public void PLAYs2()
    {
        audiosource.clip = s2;
        audiosource.Play();
    }
    public void PLAYs3()
    {
        audiosource.clip = s3;
        audiosource.Play();
    }
    public void PLAYs4()
    {
        audiosource.clip = s4;
        audiosource.Play();
    }
    public void PLAYs5()
    {
        audiosource.clip = s5;
        audiosource.Play();
    }
    public void PLAYs6()
    {
        audiosource.clip = s6;
        audiosource.Play();
    }
    public void PLAYs7()
    {
        audiosource.clip = s7;
        audiosource.Play();
    }
    public void PLAYs8()
    {
        audiosource.clip = s8;
        audiosource.Play();
    }
    public void PLAYs9()
    {
        audiosource.clip = s9;
        audiosource.Play();
    }
    public void PLAYs10()
    {
        audiosource.clip = s10;
        audiosource.Play();
    }
    public void PLAYs11()
    {
        audiosource.clip = s11;
        audiosource.Play();
    }
    public void PLAYs12()
    {
        audiosource.clip = s12;
        audiosource.Play();
    }
}

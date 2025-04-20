using UnityEngine;

public class SE : MonoBehaviour
{
    public AudioClip rock, du, hit, eat, recall, boardwater, get, moss,book,button;
    AudioSource audiosource;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    public void PLAYrock()
    {
        audiosource.clip = rock;
        audiosource.Play();
    }

    public void PLAYdu()
    {
        audiosource.clip = du;
        audiosource.Play();
    }

    public void PLAYhit()
    {
        audiosource.clip = hit;
        audiosource.Play();
    }

    public void PLAYeat()
    {
        audiosource.clip = eat;
        audiosource.Play();
    }

    public void PLAYboardwater()
    {
        audiosource.clip = boardwater;
        audiosource.Play();
    }
    public void PLAYget()
    {
        audiosource.clip = get;
        audiosource.Play();
    }
    public void PLAYrecall()
    {
        audiosource.clip = recall;
        audiosource.Play();
    }
    public void PLAYmoss()
    {
        audiosource.clip = moss;
        audiosource.Play();
    }
    public void PLAYbook()
    {
        audiosource.clip = book;
        audiosource.Play();
    }

    public void PLAYbutton()
    {
        audiosource.clip = button;
        audiosource.Play();
    }
}
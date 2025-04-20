using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioClip gameover,C3CM;
    AudioSource audiosource;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    public void PLAYgameover()
    {
        audiosource.clip = gameover;
        audiosource.Play();
        audiosource.loop = false;
    }

    public void PLAYC3CM()
    {
        audiosource.clip = C3CM;
        audiosource.Play();
    }
}

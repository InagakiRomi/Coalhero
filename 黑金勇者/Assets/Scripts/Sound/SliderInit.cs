using UnityEngine;
using UnityEngine.UI;

public class SliderInit : MonoBehaviour
{
    public GameObject POpen, Gameplay;
    public Slider BGMSlider, SESlider;
    public float BGMVolue, SEVolue;
    private GM GM;

    public void Start()
    {
        BGMSlider.value = PlayerPrefs.GetFloat("BGMMusic", BGMVolue);
        SESlider.value = PlayerPrefs.GetFloat("SEMusic", SEVolue);
        GM = GameObject.Find("GM").GetComponent<GM>();
    }
    void Update()
    {
        if (GM != null)
        {
            if (GM.controls == true)
            {
                if (Input.GetKeyUp(KeyCode.P))
                {
                    Pause();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (POpen.activeInHierarchy == true && Gameplay.activeInHierarchy == false)
            {
                Pause();
            }
            if (Gameplay.activeInHierarchy == true)
            {
                Gameplay.SetActive(false);
            }
        }
    }
    public void BGMVolume(float value)
    {
        BGMVolue = value;
        PlayerPrefs.SetFloat("BGMMusic", BGMVolue);
    }
    public void SEVolume(float value)
    {
        SEVolue = value;
        PlayerPrefs.SetFloat("SEMusic", SEVolue);
    }
    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            POpen.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            POpen.SetActive(false);
        }
    }
}

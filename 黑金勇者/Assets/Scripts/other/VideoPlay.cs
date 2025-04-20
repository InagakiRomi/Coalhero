using UnityEngine;
using UnityEngine.Video;

public class VideoPlay : MonoBehaviour
{
    public VideoPlayer vidPlayer;
    public enum ItemTypeList
    {
        Begin, Final
    }
    public ItemTypeList type;
    void Start()
    {
        vidPlayer = GetComponent<VideoPlayer>();
        if (type == ItemTypeList.Begin)
        {
            string filePath = "http://140.129.140.27/hclu/coalhero/beginVideo.mp4";
            vidPlayer.url = filePath;
            VP();
        }
        if (type == ItemTypeList.Final)
        {
            string filePath = "http://140.129.140.27/hclu/coalhero/finalVideo.mp4";
            vidPlayer.url = filePath;
            VP();
        }

    }

    public void VP()
    {
        vidPlayer.renderMode = VideoRenderMode.CameraNearPlane;
        vidPlayer.targetCameraAlpha = 1.0f;
        vidPlayer.Play();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string SceneName;
    private Settings Set;
    private Achievement SA;

    void Start()
    {
        Set = GameObject.Find("設定和音樂").GetComponent<Settings>();
        SA = GameObject.Find("GM").GetComponent<Achievement>();
    }
        void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.transform.tag == "Player")
        {
            Set.SetFloat();
            string RestartSceneName = SceneManager.GetActiveScene().name;
            if (RestartSceneName == "2第二關")
            {
                SA.Better();
            }
            if (RestartSceneName == "3第三關")
            {
                SA.Escape();
            }
            if (RestartSceneName == "4第四關")
            {
                SA.NotDead();
            }
            SceneManager.LoadScene(SceneName);
        }
    }
}

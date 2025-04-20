using UnityEngine;
using UnityEngine.SceneManagement;

public class MosterHP : MonoBehaviour
{
    public GameObject Hp_Bar;
    public int HP;
    public float HP_Max;

    public int 掉東西的機率;
    public GameObject ii;

    private Player PHP;
    private float damageRate = 1;
    float nextDamage;

    private SE SE;
    public GameObject PS1,PS2; //特效

    private Achievement SA;
    public enum ItemTypeList
    {
        Slime, Bat
    }
    public ItemTypeList type;

    void Start()
    {
        SA = GameObject.Find("GM").GetComponent<Achievement>();
        PHP = GameObject.Find("主角").GetComponent<Player>();
        SE = GameObject.Find("SE").GetComponent<SE>();
        nextDamage = 0f;

        string RestartSceneName = SceneManager.GetActiveScene().name;
        if (RestartSceneName == "4第四關")
        {
            掉東西的機率 = 0;
        }
    }
    void Update()
    {
        Hp_Bar.transform.localScale = new Vector3(HP / HP_Max, 1, 1);
    }

    void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.tag == "十字鎬"){
            if (HP > 0)
            {
                HP -= 20;
                SE.PLAYhit();
                Instantiate(PS1, transform.position, transform.rotation);
            }
            if (HP <= 0){
                int i = Random.Range(0, 101);
                if (i < 掉東西的機率)
                {
                    Instantiate(ii, transform.position, transform.rotation);
                    Instantiate(PS2, transform.position, transform.rotation);
                }
            }
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (coll.transform.position.x < transform.position.x){
                coll.transform.position += new Vector3(-0.5f, 0, 0);
            }
            else{
                coll.transform.position += new Vector3(0.5f, 0, 0);
            }
            if (HP > 0)
            {
                if (nextDamage < Time.time)
                {
                    PHP.受傷(1);
                    SE.PLAYdu();
                    if (type == ItemTypeList.Slime)
                    {
                        SA.Slime();
                    }
                    else if(type == ItemTypeList.Bat)
                    {
                        SA.Bat();
                    }
                    nextDamage = Time.time + damageRate;
                }
            }
        }
    }
}

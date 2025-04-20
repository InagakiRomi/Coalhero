using System.Collections;
using UnityEngine;

public class C3_Rockfall : MonoBehaviour
{
    public GameObject box;
    public GameObject[] Rock;
    public float 落下間隔;
    public bool RF;
    private float 落下;

    void Start()
    {
        RF = false;
    }
    void Update()
    {
        if (RF == true)
        {
            if (Time.time >= 落下)
            {
                int i = Random.Range(0, Rock.Length);
                GameObject m = Instantiate(Rock[i], new Vector3(Random.Range(-26f, 37f), 27, 0), Quaternion.identity);
                m.transform.parent = box.transform;
                落下 = Time.time + 落下間隔;
            }
        }   
    }

    public void RFopen()
    {
        RF = true;
    }
}

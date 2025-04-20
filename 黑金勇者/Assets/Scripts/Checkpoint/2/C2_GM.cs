using System.Collections.Generic;
using UnityEngine;


public class C2_GM : MonoBehaviour
{
    public GameObject[] G_Object, Rock;
    public List<int> TakeList = new List<int>();
    private int randomnumber;

    void Start()
    {
        TakeList = new List<int>(new int[G_Object.Length]);
        for (int i = 0; i < G_Object.Length; i++)
        {
            randomnumber = Random.Range(1, (Rock.Length) + 1);
            while (TakeList.Contains(randomnumber))
            {
                randomnumber = Random.Range(1, (Rock.Length) + 1);
            }
            TakeList[i] = randomnumber;
            GameObject m = Instantiate(Rock[(TakeList[i] - 1)], G_Object[i].transform.position, Quaternion.identity);
            m.transform.parent = G_Object[i].transform;
        }
    }
}

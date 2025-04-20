using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject player;
    public float UP, Down, Left, Right;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (player != null)
        {
            float x = Mathf.Clamp(player.transform.position.x, Left, Right);
            float y = Mathf.Clamp(player.transform.position.y, Down, UP);
            Vector3 V = new Vector3(x, y, -10);
            transform.position = Vector3.Lerp(transform.position, V, 0.1f);
        }
    }
}

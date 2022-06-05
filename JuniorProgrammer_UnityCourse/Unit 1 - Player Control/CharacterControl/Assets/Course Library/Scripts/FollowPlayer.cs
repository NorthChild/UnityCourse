using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(-3, 6, -9);


    void Start()
    {
        
    }

    void Update()
    {
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}

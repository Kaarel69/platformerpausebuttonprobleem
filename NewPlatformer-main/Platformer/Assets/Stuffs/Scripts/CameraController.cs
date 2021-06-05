using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform player;
    private Vector3 position;

    private void Awake()
    {
        if (!player)
        {
            player = FindObjectOfType<Hero>().transform;
        }
    }
    void Start()
    {

    }

    void Update()
    {
        if (player)
        {
            position = player.position;
            position.z = -10f;

            transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime);
        }
        
    }
}

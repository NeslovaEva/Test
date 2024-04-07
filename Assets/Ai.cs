using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private float speed;
    [SerializeField] private float derection;


    void Start()
    {
        
    }

    void Update()
    {
        var delta = player.transform.position - transform.position;
        if (delta.magnitude > derection) {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}

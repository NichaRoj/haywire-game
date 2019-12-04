﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnTrigger : MonoBehaviour
{
    public GameObject spawn;
    public Vector3 position = new Vector3(0.0F, 0.0F, 0.0F);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Instantiate(spawn, position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

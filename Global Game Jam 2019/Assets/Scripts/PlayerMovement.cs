﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour {

    [SerializeField]
    float moveSpeed = 1f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (isLocalPlayer)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontal, 0f, vertical);
            transform.position += movement * Time.deltaTime * moveSpeed;
        }
	}
}

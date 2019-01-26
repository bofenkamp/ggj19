using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SwipeBall : NetworkBehaviour {

    Vector2 startPos, endPos, direction;        //Touch start position, end position, direction
    float touchTimeStart, touchTimeFinish, timeInterval;    //To calculate swipe time to control throw force in Z direction

    [SerializeField]
    float throwForceInXAndY = 1f;   //To control throw force in X and Y dirs

    [SerializeField]
    float throwForceInZ = 50f; //To control throw force in Z direction

    Rigidbody rb;

	void Start () {
        rb = GetComponent<Rigidbody>();	
	}
	
	void Update () {

        if (!hasAuthority)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.transform.Translate(0, 0.02f, 0);
        }

        if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began)    //When you touch the screen
        {
            touchTimeStart = Time.time;
            startPos = Input.GetTouch(0).position;
            Debug.Log("I got touched");
        }

        if(Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended)
        {

            touchTimeFinish = Time.time;
            timeInterval = touchTimeFinish - touchTimeStart;

            endPos = Input.GetTouch(0).position;    //Getting release finger position

            direction = startPos - endPos;          //Calculating swipe direction in 2D space

            rb.isKinematic = false;
            //Add force to ball's rigidbody in 3D space depending on above variables
            rb.AddForce(-direction.x * throwForceInXAndY, -direction.y * throwForceInXAndY, throwForceInZ / timeInterval);
        }

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBall : MonoBehaviour {

    // Use this for initialization

    [SerializeField]
    GameObject ballPrefab;

    [SerializeField]
    GameObject ballGameObject;

    Vector3 OriginalPos;


    private void Awake()
    {
        OriginalPos = ballGameObject.transform.position;
    }

    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void RespawnIt()
    {
        
        Destroy(ballGameObject);
        ballGameObject = Instantiate(ballPrefab, OriginalPos, Quaternion.identity);
    }
}

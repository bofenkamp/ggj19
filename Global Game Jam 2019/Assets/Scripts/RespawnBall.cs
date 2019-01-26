using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBall : MonoBehaviour {

    // Use this for initialization

    [SerializeField]
    GameObject ballPrefab;


    GameObject ballGameObject;

    Vector3 OriginalPos;
    

    private void Awake()
    {
        OriginalPos = ballPrefab.transform.position;
    }

    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void RespawnIt()
    {
        /*
        if (ballGameObject != null)
            Destroy(sb.gameObject);
        
        ballGameObject = Instantiate(ballPrefab, OriginalPos, Quaternion.identity);
        */
    }
}

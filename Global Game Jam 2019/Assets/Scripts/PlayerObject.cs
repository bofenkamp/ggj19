using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerObject : NetworkBehaviour {

    // Use this for initialization

    public GameObject SpherePrefab;

	void Start () {
        if (!isLocalPlayer)
            return;

        CmdSpawnMyUnit();
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
            return;
        
    }
    

    [Command]
    void CmdSpawnMyUnit()
    {
        GameObject go = Instantiate(SpherePrefab);

        NetworkServer.SpawnWithClientAuthority(go, connectionToClient);
    }


}

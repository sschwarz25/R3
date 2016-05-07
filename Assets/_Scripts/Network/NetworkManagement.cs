using UnityEngine;
using System.Collections;

public class NetworkManagement : Photon.PunBehaviour {

	public string gameVersion;


	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectToBestCloudServer (gameVersion);
	}
	
	void OnGUI(){
		GUILayout.Label (PhotonNetwork.connectionStateDetailed.ToString ());
	}

}

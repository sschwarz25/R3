using UnityEngine;
using System.Collections;

public class DemoRPGMovement : MonoBehaviour 
{
    public RPGCamera Camera;

    void OnJoinedRoom()
    {
        CreatePlayerObject();
    }

    void CreatePlayerObject()
    {
		Vector3 position = new Vector3( 189.903f, 40f, 17.1f );

        GameObject newPlayerObject = PhotonNetwork.Instantiate( "Skeleton_footman_Prefab", position, Quaternion.identity, 0 );

        Camera.Target = newPlayerObject.transform;
    }
}

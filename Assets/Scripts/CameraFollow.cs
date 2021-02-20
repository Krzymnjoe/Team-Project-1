using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform FollowP;
    // Update is called once per frame
    void FixedUpdate () {
        this.transform.position = new Vector3 (FollowP.position.x, FollowP.position.y);

    }
}
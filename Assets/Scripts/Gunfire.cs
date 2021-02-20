using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfire : MonoBehaviour {
    public GameObject bullet;
    public Transform firing;
    public int firespeed;

    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.X)) {
            Instantiate (bullet, firing.position, firing.rotation);

        }

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chargedshot : MonoBehaviour {
    public Rigidbody2D Charge;
    public int firespeed;
    public float Chargetime = 0;
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey (KeyCode.X)) {
            Chargetime += Time.deltaTime;

        }
        if ((Input.GetKeyUp (KeyCode.X)) && (Chargetime > 3)) {
            Rigidbody2D fire = Instantiate (Charge, transform.position, transform.rotation);
            fire.velocity = transform.right * firespeed;
            Chargetime = 0;
        }
        if ((Input.GetKeyUp (KeyCode.X)) && (Chargetime < 3)) {

        }

    }

}
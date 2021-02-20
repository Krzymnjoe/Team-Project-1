using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testfire : MonoBehaviour {

    // Update is called once per frame
    private void Update () {
        if (Input.GetKeyDown (KeyCode.X)) {
            Debug.Log ("Button Down");
        }
        if (Input.GetKeyUp (KeyCode.X)) {
            Debug.Log ("Button Up");
        }

    }
}
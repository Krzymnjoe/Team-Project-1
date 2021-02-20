using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    private void OnTriggerEnter2D (Collider2D trig) {
        if (trig.CompareTag ("Bullet")) {
            DetroyE ();
        }
    }
    private void DetroyE () {
        Destroy (gameObject);
    }
}
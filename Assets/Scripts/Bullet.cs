using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    Rigidbody2D Rb2D;
    public float timer;
    public float speed = 20f;

    void Start () {
        Rb2D = GetComponent<Rigidbody2D> ();
        Invoke ("DestroyB", timer);
        Rb2D.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update () {

    }
    private void OnCollisionEnter2D (Collision2D other) {
        if (other.gameObject.CompareTag ("Map")) {
            DestroyB ();
        }
        if (other.gameObject.CompareTag ("Enemy")) {
            DestroyB ();
        }

    }

    private void DestroyB () {
        Destroy (gameObject);
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public float speed = 0f;
    public float Movement;
    public Text Livescount;
    public int lives = 0;

    public float jumpPower = 0f;
    public Rigidbody2D bullet;

    private Transform transf;
    private Rigidbody2D Rb2D;

    // Start is called before the first frame update
    void Start () {
        transf = GetComponent (typeof (Transform)) as Transform;
        Rb2D = GetComponent (typeof (Rigidbody2D)) as Rigidbody2D;
        Livescount.text = "Lives:" + lives.ToString ();

    }

    // Update is called once per frame
    void FixedUpdate () {
        Moveplay ();

        Jump ();
        if (Input.GetKeyDown (KeyCode.X)) {
            Fire ();
        }

    }
    void Moveplay () {
        Movement = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
        transf.Translate (Movement, 0, 0);

    }
    void Jump () {
        if (Input.GetKeyDown (KeyCode.Space)) {
            Rb2D.AddForce (new Vector2 (0, jumpPower), ForceMode2D.Impulse);
        }
    }
    void Fire () {
        Rigidbody2D shot = Instantiate (bullet, transf.position, transf.rotation);

    }
    void OnTriggerExit2D (Collider2D other) {
        if (other.gameObject.CompareTag ("Enemy")) {
            lives = lives - 1;
            Livescount.text = "Lives: " + lives.ToString ();
        }
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleBola : MonoBehaviour {
    private Rigidbody rb;
    public float velocidade;
    public float maxAltura;

    void Start () {

        rb = GetComponent<Rigidbody> ();
        velocidade = 20;
        maxAltura = 3;
    }

    void FixedUpdate () {
        float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

        float pulo = 0;

        if ((Input.GetKey (KeyCode.Space)) && (rb.position.y < maxAltura)) {
			pulo = 2;
		}

        Vector3 forca = new Vector3 (h, pulo, v);
		rb.AddForce (forca * velocidade);

    }
}
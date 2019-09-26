using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alterarEscala : MonoBehaviour {

    float escala;

    void Start () {
        this.escala = 0.1f;
    }

    void Update () {

        if (Input.GetKey (KeyCode.G)) {
            if (transform.localScale.x < 20) {
                transform.localScale += new Vector3 (escala, 0, 0);
            }
        }

        if (Input.GetKey (KeyCode.H)) {
            if (transform.localScale.x > 1) {
                transform.localScale += new Vector3 (-(escala), 0, 0);
            }
        }

    }
}
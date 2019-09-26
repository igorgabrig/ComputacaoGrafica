using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goleiro : MonoBehaviour {
    void Start () {

    }

    void Update () {

        if (transform.position.x > 3) {
            transform.Translate (new Vector3 (-(10 * Time.deltaTime), 0, 0));
        }

        if (transform.position.x < (-16)) {

            transform.Translate (new Vector3 ((10 * Time.deltaTime), 0, 0));
        }
    }

    // transform.Translate (new Vector3 (10 * Time.deltaTime, 0, 0));

}

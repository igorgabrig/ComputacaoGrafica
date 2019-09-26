using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolScript : MonoBehaviour {
    void Start () {

    }

    void Update () {

    }

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            GetComponent<AudioSource>().Play();
        }
    }

}
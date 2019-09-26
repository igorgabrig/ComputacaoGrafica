using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCamera : MonoBehaviour {

    public GameObject jogador;
    private Vector3 offset;

    void Start () {
        offset = transform.position - jogador.transform.position;
    }

    void Update () {
        Vector3 posicao = new Vector3 (jogador.transform.position.x, 0f, jogador.transform.position.z);
        transform.position = posicao + offset;
    }
}
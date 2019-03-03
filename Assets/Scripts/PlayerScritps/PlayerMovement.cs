using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    private float MaxSpeed;
    [SerializeField]
    private float currentSpeed;

    void Start() {

    }

    void Update() {
        Movement();
    }

    private void Movement() {
        transform.position += transform.forward * Time.deltaTime * MaxSpeed;
        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));
    }
}

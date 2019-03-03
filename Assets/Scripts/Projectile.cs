using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(DestoryTimer(5));
    }
    void Update() {
        if (rb != null)
        {
            rb.AddForce(transform.forward * speed);
        }
    }

    private IEnumerator DestoryTimer(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Player") {
            Destroy(this.gameObject);
        }
    }

    
}

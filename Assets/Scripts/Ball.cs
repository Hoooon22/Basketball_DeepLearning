using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ShootForceX = 30f;
    public float ShootForceY = 30f;
    public float ShootForceZ = 30f;

    private Rigidbody rigidbody;
    private MeshRenderer meshRenderer;
    private float DestroyTime = 3f;

    void Awake () {
        rigidbody = GetComponent<Rigidbody> ();
        rigidbody.AddForce(ShootForceX, ShootForceY, ShootForceZ);
        meshRenderer = GetComponent<MeshRenderer> ();
        Destroy (gameObject, DestroyTime);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;

public class Ball : Agent
{
    public float ShootForceX = 30f;
    public float ShootForceY = 30f;
    public float ShootForceZ = 30f;

    private Rigidbody rigidbody;
    private MeshRenderer meshRenderer;
    private float DestroyTime = 3f;
    
    private bool isCandidate = false;
    private bool isGoal = false;

    void Awake () {
        rigidbody = GetComponent<Rigidbody> ();
        rigidbody.AddForce(ShootForceX, ShootForceY, ShootForceZ);
        meshRenderer = GetComponent<MeshRenderer> ();
        Destroy (gameObject, DestroyTime);
    }

    public override void AgentReset() {

    }

    public override void CollectObservations() {
        
    }

    void OnTriggerEnter (Collider other) {
        if(other.CompareTag ("Upper")) {
            isCandidate = true;
        }

        if(other.CompareTag ("Lower")) {
            if(isCandidate) {
                meshRenderer.material.color = Color.green;
                isGoal = true;
            }
        }
    }
}
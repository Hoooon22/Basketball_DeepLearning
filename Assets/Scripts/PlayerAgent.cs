using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;

public class PlayerAgent : Agent
{
    public GameObject Ball;
    public Transform ShotPosition;

    void Update () {
        if (Input.GetMouseButtonDown (0)) {
            GameObject instance = Instantiate(Ball, ShotPosition.transform.position, ShotPosition.transform.rotation);
        }
    }
}

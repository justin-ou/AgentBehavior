using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour {

    public Transform seekTargetTransform;

    public Vector3 velocity;
    public Vector3 acceleration;
    public float maxSpeed = 4.0f;
    public float maxForce = 0.1f;
    public float mass = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Apply forces
        Seek(seekTargetTransform.position);

        // Move object
        velocity += acceleration;
        Vector3.ClampMagnitude(velocity, maxSpeed);
        transform.position = transform.position + velocity;
        acceleration *= 0f;

        // Rotate to look at current velocity
        transform.rotation = Quaternion.LookRotation(velocity, Vector3.up);
	}
    private void Seek(Vector3 target) {
        // Get desired target velocity
        // Normalize to vehicle speed
        // Get steering velocity based on current and target velocity
        // Limit resultant force
        Vector3 seekVelocity = target - transform.position;
        seekVelocity = seekVelocity.normalized * maxSpeed;

        Vector3 steerVelocity = seekVelocity - velocity;      
        Vector3.ClampMagnitude(steerVelocity, maxForce);

        ApplyForce(steerVelocity);
    }
    private void ApplyForce(Vector3 force) {
        if (mass > 0) force /= mass;
        acceleration += force;
    }
}

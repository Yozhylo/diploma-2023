using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fish : Entity {
	private float MinimumTankSize {
		set; get;
	}
	private float speed = 0.0f;
	private float rotationSpeed = 1.0f;
	// Waypoint movement variables
	[SerializeField][Min(1)] private int pathLength = 5;
	private int currentWaypoint = 0;
	[SerializeField][Min(1.0f)]private float waypointDistanceThreshold = 2.0f;
	private List<Vector3> waypoints = new List<Vector3>();
	// Gizmo settings
	private Color gizmoColor;

	private void OnDrawGizmos() {
		Gizmos.color = gizmoColor;

		foreach (var position in waypoints) {
			Gizmos.DrawWireSphere(position, 0.5f);
			Gizmos.DrawLine(transform.position, waypoints[currentWaypoint]);
		}
	}

	private void OnEnable() {
		// Setting up gizmos
		gizmoColor = new Color(Random.value, Random.value, Random.value);
		// Generating new waypoints
		for (int i = 0; i < pathLength; i++) {
			waypoints.Add(new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-3.0f, 3.0f), Random.Range(0.0f, 5.0f)));
		}
		// Setting simulation parameters
		speed = Random.Range(0.5f, 3.0f);
	}
	private void Update() {
		Move();
		//Decay();
	}
	private void Move() {
		// Debug.Log($@"{currentWaypoint}");
		if (Vector3.Distance(waypoints[currentWaypoint], transform.position) < waypointDistanceThreshold) currentWaypoint++;
		if (currentWaypoint > pathLength - 1) currentWaypoint = 0;
		Quaternion waypointDegree = Quaternion.LookRotation(waypoints[currentWaypoint] - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, waypointDegree, rotationSpeed * Time.deltaTime);
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class Followme : MonoBehaviour {
	NavMeshAgent nav;
	public GameObject mainPlayer;

	// Use this for initialization
	void Start () {
		nav = this.GetComponent<NavMeshAgent>();

	}

	// Update is called once per frame
	void Update () {
		nav.speed = 16;
		nav.acceleration = 20;
		nav.angularSpeed = 20;
		nav.SetDestination(mainPlayer.transform.position);
	}


}

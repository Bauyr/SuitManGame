using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class follow : MonoBehaviour {
	NavMeshAgent nav;
	public GameObject mainPlayer;
	static Animator anim;
	// Use this for initialization
	void Start () {
		nav = this.GetComponent<NavMeshAgent>();
		anim = GetComponent<Animator>();

	}
		
	// Update is called once per frame
	void Update () {
		
		if (Math.Abs(Math.Abs(mainPlayer.transform.position.x)-Math.Abs(nav.transform.position.x))<	40){
			nav.SetDestination(mainPlayer.transform.position);
			anim.SetBool ("IsWalking",true);

		}
		if (Math.Abs(Math.Abs(mainPlayer.transform.position.x)-Math.Abs(nav.transform.position.x))==40 || Math.Abs(Math.Abs(mainPlayer.transform.position.x)-Math.Abs(nav.transform.position.x))>40){
			nav.SetDestination(nav.transform.position);
			anim.SetBool ("IsWalking",false);	
		}


	}


}

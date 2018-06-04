using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetFloat("moveH",Input.GetAxis("Horizontal"));
		anim.SetFloat("moveV",Input.GetAxis("Vertical"));
	}
}
	
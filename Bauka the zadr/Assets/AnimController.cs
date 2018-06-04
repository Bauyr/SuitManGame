using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AnimController : MonoBehaviour
{	
	public Text scoretext;
	public Text healthtext;
	public Text timertext;
	static float timer = 0.0f;
	public Text gameovertext;
	public GameObject camera01;
	public GameObject opendoor;
	static Animator anim;
	public float speed = 18.0f;
	public float rotationSpeed = 100.0f;
	int c=0;
	int hp=100;
	// Use this for initialization
	void Start ()
	{	

		scoretext.color = Color.red;
		scoretext.text = "Score: ";
		gameovertext.text = "";
		healthtext.fontSize =25;
		healthtext.color = Color.green;
		healthtext.text = "Health: "+hp.ToString();
		anim = GetComponent<Animator> ();
	} 

	// Update is called once per frame
	void Update ()
	{ 
		float translation = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;

		transform.Translate (0, 0, translation);
		transform.Rotate (0, rotation, 0);  
		if(Input.GetKeyDown(KeyCode.R)){
			anim.SetBool("IsWalking", true);
		}
		if(Input.GetKeyUp(KeyCode.R)){
			anim.SetBool ("IsWalking", false);
		} 
		if (Input.GetKeyDown (KeyCode.E)) {
			speed = 23.0f;
		}
		if (Input.GetKeyUp(KeyCode.E)) {
			speed = 18.0f;
		}

		timer += Time.deltaTime;
		timertext.color = Color.red;
		timertext.text = timer.ToString ("0.00");

	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "coin") {
			c +=1;
			scoretext.fontSize =25;
			scoretext.color = Color.white;
			scoretext.text = "Score: "+c.ToString ();
		}
		if (c > 9) {
			Destroy (this.opendoor);
		}
		if(other.tag=="box" && c>9)
			{
			
			gameovertext.text= ("NOW YOU CAN PASS TO NEXT LEVEL");
			SceneManager.LoadScene(2);
			}
		if (other.tag == "klad") {
			gameovertext.text=("YOU WON THE GAME!");
			SceneManager.LoadScene(3);
		}
		if (other.tag == "bot") {
			hp -= 10;
			healthtext.text = "Health: "+hp.ToString ();
		}
		if (other.tag == "botkiller") {
			hp =0;
			gameovertext.text= ("GAMER OVER!!!");
			SceneManager.LoadScene (4);
		}
		if(hp==0)
		{
			gameovertext.fontSize =35;
			gameovertext.color = Color.green;
			gameovertext.text = "GAME OVER!!!";
			SceneManager.LoadScene (4);


		}
	}

}﻿
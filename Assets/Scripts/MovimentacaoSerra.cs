﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoSerra : MonoBehaviour {

	private Rigidbody2D rb2D;


	// Use this for initialization
	void Start () {

		rb2D = GetComponent<Rigidbody2D> ();
		rb2D.velocity = new Vector2 (1.5f, rb2D.velocity.y);

		
	}

	// Update is called once per frame
	void Update () {

		//rb2D.rotation = new Vector2 (rb2D.rotation + 1f, rb2D.rotation.y);

		rb2D.transform.Rotate (0,0,10);

		if (rb2D.position.x > 4) {
			//Debug.Log ("Posicao 1: " + rb2D.position.x);
			//Debug.Log ("Velocidade 1: " + rb2D.velocity.y);
			rb2D.velocity = new Vector2 (-1.5f , rb2D.velocity.y);
			
		}if (rb2D.position.x < -4) {
			//Debug.Log ("Posicao 2: " + rb2D.position.x);
			//Debug.Log ("Velocidade 2: " + rb2D.velocity.y);
			rb2D.velocity = new Vector2 (1.5f, rb2D.velocity.y);
			
		}

		//Debug.Log (rb2D.velocity.x );

	}
}

﻿using UnityEngine;
using System.Collections;

public class MonsterMove : MonoBehaviour {




	public Transform targetTranPointer = null;
	private Transform playerTranPointer = null;
	public float moveSpeed = 1f;



	void Start () {
		playerTranPointer = GameObject.FindGameObjectWithTag("Girl").transform;	
	}
	void Update () {
		Vector3 movePos = new Vector3(0f,0f,0f);
		
		if(transform.position.x < playerTranPointer.position.x){
			movePos.x -= moveSpeed * Time.deltaTime;
		}
		else{
			movePos.x -= moveSpeed * Time.deltaTime;
		}

		/*
		if(targetTranPointer.position.y < playerTranPointer.position.y){
			movePos.y += moveSpeed*0.5f * Time.deltaTime;
		}else{
			movePos.y -= moveSpeed*0.5f * Time.deltaTime;
		}
		*/

		transform.position += movePos;
		//print (moveSpeed);
	}
}
	


	


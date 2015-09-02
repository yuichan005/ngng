using UnityEngine;
using System.Collections;

public class TimeEnd : MonoBehaviour {



	public Texture myWin;

	
	//private float startTime = 0f;
	
	
	void Start(){
		//startTime = Time.deltaTime;
		//gameTime = 5;
		
	}
	
	void Update(){
		/*if(gameTime ==0){
			Destroy(gameObject);
		}

		if(gameTime >= 1){
			gameTime-=1*Time.deltaTime ;
			
		}else if(gameTime == 0){
			

		}
		
		*/
		
	}
	void OnGUI(){

		GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), myWin);
			//Application.LoadLevel("Win");
			
		

	
		
	}

}

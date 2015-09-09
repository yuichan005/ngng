using UnityEngine;
using System.Collections;

public class Page2 : MonoBehaviour {

		
		public Texture mybg;
		
		
		void OnGUI () {
			
			GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), mybg);
			
			
		}
		
	

}

using UnityEngine;
using System.Collections;

public class TestCorou : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (waitToShow (5f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator waitToShow (float seconds)
	{
		Debug.Log("Wait 5 milliseconds for Next Page");
		yield return new WaitForSeconds (seconds);
		Debug.Log ("Page2");
		Application.LoadLevel("NextPage");
	}
}
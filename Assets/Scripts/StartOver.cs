using UnityEngine;
using System.Collections;

public class StartOver : MonoBehaviour {

//	public Quiz quiz;
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnClick () {
		Application.LoadLevel (Application.loadedLevel);
	}
}

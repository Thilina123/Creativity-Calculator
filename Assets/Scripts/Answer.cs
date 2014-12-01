using UnityEngine;
using System.Collections;

public class Answer : MonoBehaviour {

	public Quiz quiz;
	public int score=5;
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnClick () {
		quiz.NextQuestion (score);
	}
}

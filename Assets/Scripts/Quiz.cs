using UnityEngine;
using System.Collections;

public class Quiz : MonoBehaviour {

	public UILabel qLabel,sumLabel, resLabel;
	public GameObject result,quiz;
	public string[] questions,results;
	int score=0;
	int qNo=0;
	void Start () {
		score = 0;
		qLabel.text = questions [0];
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A)) {
			Debug.Log("next");
			NextQuestion(5);	
		}
	}
	public void NextQuestion(int sc){
		Debug.Log("next");
		score+=sc;
		sumLabel.text = "Sum : " + score;
		qNo++;
		if (qNo >= questions.Length) {
			ShowResults ();
		} else {
			qLabel.text=questions[qNo];
		}
	}
	public void ShowResults(){
		result.SetActive (true);
		if (score > 100) {
			resLabel.text=results[2];
			return;
		}
		if (score > 50) {
			resLabel.text=results[1];
			return;
		}
		resLabel.text=results[0];
		gameObject.SetActive (false);

	}
}

using UnityEngine;
using System.Collections;

public class Car_and_rame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "MapQuit") {
			//Debug.Log ("kkk");
			var ps = GameObject.Find("Panel");
			ps.SetActive;
		}
	}

	// Update is called once per frame
	void Update () {
	}
}

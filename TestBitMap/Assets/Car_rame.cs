using UnityEngine;
using System.Collections;

public class Car_rame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "Car") {
			//Debug.Log ("kkk");
			var ps = GameObject.Find("Panel");
			ps.SetActive(true);
		}
	}


	// Update is called once per frame
	void Update () {
	
	}
}

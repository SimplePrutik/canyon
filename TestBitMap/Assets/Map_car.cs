using UnityEngine;
using System.Collections;

public class Map_car : MonoBehaviour {

	public int Count1 = 0;
	public int Count2 = 0;
	public int Count3 = 0;

	// Use this for initialization
	void Start () {
	
	}
		
	void OnTriggerEnter(Collider other){
		if (other.name == "Prutik1") {
			var pr1 = GameObject.Find("Prutik1");
			var heading = this.transform.position - pr1.transform.position;
			int Count1 = heading.sqrMagnitude;
			//int x = this.transform.position.x;
			//int y = this.transform.position.y;
			//int z = this.transform.position.z;
			//int px = pr1.transform.position.x;
			//int py = pr1.transform.position.y;
			//int pz = pr1.transform.position.z;
		}	

		if (other.name == "Prutik2") {
			var pr2 = GameObject.Find("Prutik2");
			var heading = this.transform.position - pr2.transform.position;
			int Count2 = heading.sqrMagnitude;
		}

		if (other.name == "Prutik3") {
			var pr3 = GameObject.Find("Prutik1");
			var heading = this.transform.position - pr3.transform.position;
			int Count3 = heading.sqrMagnitude;
		}
	}
		
	// Update is called once per frame
	void Update () {
	}
}

using UnityEngine;
using System.Collections;

public class Sensor_Left : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider other)
    {
        this.transform.parent.transform.parent.transform.Rotate(new Vector3(0, 200, 0) * Time.deltaTime);  //test
    }
}

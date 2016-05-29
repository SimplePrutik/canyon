using UnityEngine;
using System.Collections;

public class Parameters : MonoBehaviour {


    public float rotation;
    public float acceleration;
    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        speed += acceleration;
	}
}

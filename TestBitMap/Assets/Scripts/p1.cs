using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class p1 : MonoBehaviour {

    public Sprite Target;
    public Image img;

    // Use this for initialization
    void Start () {
        img.sprite = Target;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

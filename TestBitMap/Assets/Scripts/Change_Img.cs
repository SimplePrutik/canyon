using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Change_Img : MonoBehaviour {

    public Image Source;
    public Sprite Target;


	// Use this for initialization
	void Start () {
        //Source = GetComponent<Image>();
        Source.sprite = null;
        Source.overrideSprite = Target;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

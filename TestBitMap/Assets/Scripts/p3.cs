using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class p3 : MonoBehaviour
{
    public Image img;
    public Sprite Target;

    // Use this for initialization
    void Start()
    {
        img.overrideSprite = Target;
    }

    // Update is called once per frame
    void Update()
    {
        img.overrideSprite = Target;
    }
}

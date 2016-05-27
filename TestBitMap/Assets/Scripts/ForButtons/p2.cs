using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class p2 : MonoBehaviour
{
    public Image img;
    public Sprite Target;

    // Use this for initialization
    void Start()
    {
        img.sprite = Target;
    }

    // Update is called once per frame
    void Update()
    {
        img.sprite = Target;
    }
}

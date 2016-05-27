using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class p4 : MonoBehaviour
{
    public Image img;
    public Sprite Target;


    // Use this for initialization
    void Start()
    {
        StartCoroutine(Example());
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Example());
    }


    IEnumerator Example()
    {
        WWW www = new WWW("http://radikal.ru/content/images/My_Video_Apps.png");
        yield return www;
        Rect rec = new Rect(0, 0, www.texture.width, www.texture.height);
        img.overrideSprite = Sprite.Create(www.texture, rec, new Vector2(0, 0), .01f);
    }

}

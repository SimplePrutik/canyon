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
        StartCoroutine(Example1());
    }


    IEnumerator Example()
    {
        // WWW www = new WWW("http://stud.mmcs.sfedu.ru/~alexandra/Map.png");
        WWW www = new WWW("http://stud.mmcs.sfedu.ru/~alexandra/Map.png");
        yield return www;
        Rect rec = new Rect(0, 0, www.texture.width, www.texture.height);
        img.sprite = Sprite.Create(www.texture, rec, new Vector2(0, 0), 0.1f);
    }

    IEnumerator Example1()
    {
        // WWW www = new WWW("http://stud.mmcs.sfedu.ru/~alexandra/Map.png");
        WWW www = new WWW("http://stud.mmcs.sfedu.ru/~alexandra/Map.png");
        yield return www;
        Rect rec = new Rect(0, 0, www.texture.width, www.texture.height);
        img.sprite = Sprite.Create(www.texture, rec, new Vector2(0, 0), 0.1f);
    }

}

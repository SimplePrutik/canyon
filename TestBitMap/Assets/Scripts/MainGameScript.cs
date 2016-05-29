using UnityEngine;
using UnityEditor;
using System.Collections;

public class MainGameScript : MonoBehaviour {

    public GameObject Block;
    public GameObject QuitBlock;
    public UnityEngine.UI.InputField SX;
    public UnityEngine.UI.InputField SY;
    public UnityEngine.UI.Image imgg;
    const int maxWidth = 182;
    const int maxHeight = 102;
    GameObject[,] MapArea = new GameObject[maxWidth, maxHeight];
    int P = 150;


    public static void SetTextureImporterFormat(Texture2D texture, bool isReadable)
    {
        if (null == texture) return;

        string assetPath = AssetDatabase.GetAssetPath(texture);
        var tImporter = AssetImporter.GetAtPath(assetPath) as TextureImporter;
        if (tImporter != null)
        {
            tImporter.textureType = TextureImporterType.Advanced;

            tImporter.isReadable = isReadable;

            AssetDatabase.ImportAsset(assetPath);
            AssetDatabase.Refresh();
        }
    }

    class TextureImporterExample : AssetPostprocessor
    {
        void OnPreprocessTexture()
        {
            TextureImporter textureImporter = assetImporter as TextureImporter;
            //textureImporter.compressionQuality = (int)TextureCompressionQuality.Best;
            //textureImporter.textureFormat = TextureImporterFormat.RGB24;
            textureImporter.isReadable = true;
        }
    }

    void GenMap()
    {
        Vector3 PointStart = new Vector3(0, 0, 0);
        // Texture2D tex = new Texture2D((int)img.rect.width, (int)img.rect.height);
        Sprite sprite;
        //Debug.Log(imgg.mainTexture);
        Texture2D newText = (Texture2D)imgg.mainTexture;
        //Texture2D newText = new Texture2D((int)sprite.rect.width, (int)sprite.rect.height);
        //SetTextureImporterFormat(newText, true);
        
        
        //Color[] newColors = sprite.texture.GetPixels((int)sprite.textureRect.x,
        //                                            (int)sprite.textureRect.y,
        //                                            (int)sprite.textureRect.width,
        //                                            (int)sprite.textureRect.height);
        //newText.SetPixels(newColors);
        //newText.Apply();
        //Debug.Log(newText.width);
        //var pixels = img.texture.GetPixels((int)img.textureRect.x,
        //                                (int)img.textureRect.y,
        //                                (int)img.textureRect.width,
        //                                (int)img.textureRect.height);
        //tex.SetPixels(pixels);
        //tex.Apply();
        //Debug.Log(System.IO.Directory.GetCurrentDirectory());

        // System.Drawing.Bitmap bmpImg = new System.Drawing.Bitmap(maxWidth, maxHeight);
        Color color = new Color();

        //var ratioX = (double)maxWidth / tex.width;
        //var ratioY = (double)maxHeight / tex.height;
        ////var ratio = System.Math.Min(ratioX, ratioY);

        //var newWidth = (int)(tex.width * ratioX);
        //var newHeight = (int)(tex.height * ratioY);

        //var newImage = new System.Drawing.Bitmap(newWidth, newHeight);

        //System.Drawing.Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
        System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(maxWidth, maxHeight);

        //image.Save("test.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        //Debug.Log(System.IO.Directory.GetCurrentDirectory());

        //for (int i = 0; i < newText.width; i++)
        //    for (int j = 0; j < newText.height; j++)
        //    {
        //        color = newText.GetPixel(i, j);
        //        int K = (int)((color.r + color.g + color.b) / 3);
        //        Debug.Log(K);
        //        bmp.SetPixel(i, j, (K <= P ? System.Drawing.Color.Black : System.Drawing.Color.White));
        //    }


        for (int X = 1; X < newText.width; X++)
            for (int Y = 1; Y < newText.height; Y++)
            {
                color = newText.GetPixel(X, Y);

                if (color == Color.black)
                {
                    PointStart = new Vector3(X, Y , 0);
                    MapArea[X, newText.height - Y - 1] = (GameObject)Instantiate(Block, PointStart, Quaternion.identity);
                }

            }

        Edge();
    }

    // Use this for initialization
    void Start () {
        GenMap();
        Instantiate(Resources.Load("Car"), new Vector3(System.Convert.ToInt32(SX.text), System.Convert.ToInt32(SY.text), 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Edge()
    {
        Vector3 PointStart = new Vector3(0, 0, 0);
        for (int X = 0; X < maxWidth-2; X++)
        {
            PointStart = new Vector3(X, maxHeight-3, 0);
            MapArea[X, maxHeight-1] = (GameObject)Instantiate(QuitBlock, PointStart, Quaternion.identity);
        }

        for (int X = 0; X < maxWidth-2; X++)
        {
            PointStart = new Vector3(X, 0, 0);
            MapArea[X, maxHeight-2] = (GameObject)Instantiate(QuitBlock, PointStart, Quaternion.identity);
        }

        for (int Y = 0; Y < maxHeight-3; Y++)
        {
            PointStart = new Vector3(0, Y, 0);
            MapArea[0, Y] = (GameObject)Instantiate(QuitBlock, PointStart, Quaternion.identity);
        }

        for (int Y = 0; Y < maxHeight-2; Y++)
        {
            PointStart = new Vector3(maxWidth-3, Y, 0);
            MapArea[maxWidth-1, Y] = (GameObject)Instantiate(QuitBlock, PointStart, Quaternion.identity);
        }
    }


}

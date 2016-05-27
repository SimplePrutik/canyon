using UnityEngine;
using System.Collections;

public class MainGameScript : MonoBehaviour {

    public GameObject Block;
    public GameObject QuitBlock;
    public int filename;
    GameObject[,] MapArea = new GameObject[180, 100];
    int maxWidth = 180;
    int maxHeight = 100;
    int P = 150;

    void GenMap()
    {
        //точка отсчета
        Vector3 PointStart = new Vector3(0, 0, 0);
        System.Drawing.Bitmap image;
        //if (filename >= 1 && (filename <= 3))
        Debug.Log(System.IO.Directory.GetCurrentDirectory());
        image = new System.Drawing.Bitmap("/Images/Map" + (filename.ToString()) + ".bmp", true);
        //System.Drawing.Bitmap image = new System.Drawing.Bitmap(oldimage, new System.Drawing.Size(180, 100));

        System.Drawing.Bitmap bmpImg = new System.Drawing.Bitmap(maxWidth, maxHeight);
        System.Drawing.Color color = new System.Drawing.Color();

        var ratioX = (double)maxWidth / image.Width;
        var ratioY = (double)maxHeight / image.Height;
        //var ratio = System.Math.Min(ratioX, ratioY);

        var newWidth = (int)(image.Width * ratioX);
        var newHeight = (int)(image.Height * ratioY);

        var newImage = new System.Drawing.Bitmap(newWidth, newHeight);
        System.Drawing.Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
        image = new System.Drawing.Bitmap(newImage);

        //image.Save("test.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        Debug.Log(System.IO.Directory.GetCurrentDirectory());

        for (int i = 0; i < bmpImg.Width; i++)
            for (int j = 0; j < bmpImg.Height; j++)
            {
                color = image.GetPixel(i, j);
                int K = (color.R + color.G + color.B) / 3;
                bmpImg.SetPixel(i, j, (K <= P ? System.Drawing.Color.Black : System.Drawing.Color.White));
            }

        for (int X = -1; X < bmpImg.Width; X++)
        {
            PointStart = new Vector3(X, bmpImg.Height, 0);
            MapArea[X, bmpImg.Height] = (GameObject)Instantiate(QuitBlock, PointStart, Quaternion.identity);
        }

        for (int X = -1; X < bmpImg.Width; X++)
        {
            PointStart = new Vector3(X, -1, 0);
            MapArea[X, bmpImg.Height] = (GameObject)Instantiate(QuitBlock, PointStart, Quaternion.identity);
        }

        for (int Y = -1; Y < bmpImg.Height; Y++)
        {
            PointStart = new Vector3(-1, Y, 0);
            MapArea[-1, Y] = (GameObject)Instantiate(QuitBlock, PointStart, Quaternion.identity);
        }

        for (int Y = -1;Y < bmpImg.Height; Y++)
        {
            PointStart = new Vector3(bmpImg.Width, Y, 0);
            MapArea[bmpImg.Width, Y] = (GameObject)Instantiate(QuitBlock, PointStart, Quaternion.identity);
        }


        for (int X = 0; X < bmpImg.Width; X++)
            for (int Y = 0; Y < bmpImg.Height; Y++)
            {
                color = bmpImg.GetPixel(X, Y);

                if (color == System.Drawing.Color.FromArgb(255, 0, 0, 0)) 
                {
                    PointStart = new Vector3(X, bmpImg.Height - Y - 1, 0);
                    MapArea[X, bmpImg.Height - Y - 1] = (GameObject)Instantiate(Block, PointStart, Quaternion.identity);
                }

            }


    }

    // Use this for initialization
    void Start () {
        GenMap();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

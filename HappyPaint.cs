using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Unity.IO;

public class HappyPaint : MonoBehaviour
{
    [SerializeField, Tooltip("Generated texture after paint process.")]Texture2D texture;
    [SerializeField, Tooltip("Texture export name.")] string textureName = "default";
    public void Paint(Color a1, Color a2, Color a3, Color a4,
                      Color b1, Color b2, Color b3, Color b4,
                      Color c1, Color c2, Color c3, Color c4, 
                      Color d1, Color d2, Color d3, Color d4){
        texture = new Texture2D(4,4, TextureFormat.RGBA32, 0, false);
        texture.filterMode = FilterMode.Point;
        texture.SetPixel(0,3,a1);
        texture.SetPixel(1,3,a2);
        texture.SetPixel(2,3,a3);
        texture.SetPixel(3,3,a4);
        texture.SetPixel(0,2,b1);
        texture.SetPixel(1,2,b2);
        texture.SetPixel(2,2,b3);
        texture.SetPixel(3,2,b4);
        texture.SetPixel(0,1,c1);
        texture.SetPixel(1,1,c2);
        texture.SetPixel(2,1,c3);
        texture.SetPixel(3,1,c4);
        texture.SetPixel(0,0,d1);
        texture.SetPixel(1,0,d2);
        texture.SetPixel(2,0,d3);
        texture.SetPixel(3,0,d4);
        texture.Apply();
        texture.name = textureName;
        GetComponent<Renderer>().material.mainTexture = texture;
        texture = GetComponent<Renderer>().material.mainTexture as Texture2D;
    }
    public void Save(){
        byte[] bytes = texture.EncodeToPNG();
        string path = "./Assets/" + texture.name + ".png";
        System.IO.File.WriteAllBytes(path, bytes);
        AssetDatabase.ImportAsset(path);
        Debug.Log("Saved to " + path);
        AssetDatabase.Refresh();
    }
}

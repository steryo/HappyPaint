using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(HappyPaint))]
public class HappyPaintEditor : Editor
{
    Color palette_A1 = Color.red;
    Color palette_A2 = Color.yellow;
    Color palette_A3 = Color.blue;
    Color palette_A4 = Color.green;
    Color palette_B1 = Color.white;
    Color palette_B2 = Color.magenta;
    Color palette_B3 = Color.cyan;
    Color palette_B4 = Color.black;
    Color palette_C1 = Color.yellow;
    Color palette_C2 = Color.blue;
    Color palette_C3 = Color.green;
    Color palette_C4 = Color.red;
    Color palette_D1 = Color.grey;
    Color palette_D2 = Color.cyan;
    Color palette_D3 = Color.magenta;
    Color palette_D4 = Color.white;

    Vector2 vect;
    Rect rect;
    public override void OnInspectorGUI()
    {
        HappyPaint scr = (HappyPaint)target;
        DrawDefaultInspector();

        if(GUILayout.Button("Save Texture")){
            scr.Save();
        }

        EditorGUILayout.BeginHorizontal();
        palette_A1 = EditorGUILayout.ColorField(palette_A1, GUILayout.ExpandWidth(false));
        palette_A2 = EditorGUILayout.ColorField(palette_A2, GUILayout.ExpandWidth(false));
        palette_A3 = EditorGUILayout.ColorField(palette_A3, GUILayout.ExpandWidth(false));
        palette_A4 = EditorGUILayout.ColorField(palette_A4, GUILayout.ExpandWidth(false));
        EditorGUILayout.EndHorizontal();
        
        EditorGUILayout.BeginHorizontal();
        palette_B1 = EditorGUILayout.ColorField(palette_B1, GUILayout.ExpandWidth(false));
        palette_B2 = EditorGUILayout.ColorField(palette_B2, GUILayout.ExpandWidth(false));
        palette_B3 = EditorGUILayout.ColorField(palette_B3, GUILayout.ExpandWidth(false));
        palette_B4 = EditorGUILayout.ColorField(palette_B4, GUILayout.ExpandWidth(false));
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        palette_C1 = EditorGUILayout.ColorField(palette_C1, GUILayout.ExpandWidth(false));
        palette_C2 = EditorGUILayout.ColorField(palette_C2, GUILayout.ExpandWidth(false));
        palette_C3 = EditorGUILayout.ColorField(palette_C3, GUILayout.ExpandWidth(false));
        palette_C4 = EditorGUILayout.ColorField(palette_C4, GUILayout.ExpandWidth(false));
        EditorGUILayout.EndHorizontal();
        
        EditorGUILayout.BeginHorizontal();
        palette_D1 = EditorGUILayout.ColorField(palette_D1, GUILayout.ExpandWidth(false));
        palette_D2 = EditorGUILayout.ColorField(palette_D2, GUILayout.ExpandWidth(false));
        palette_D3 = EditorGUILayout.ColorField(palette_D3, GUILayout.ExpandWidth(false));
        palette_D4 = EditorGUILayout.ColorField(palette_D4, GUILayout.ExpandWidth(false));
        EditorGUILayout.EndHorizontal();

        if(GUILayout.Button("Paint", GUILayout.Height(30))){
            scr.Paint(palette_A1, palette_A2, palette_A3, palette_A4, 
                      palette_B1, palette_B2, palette_B3, palette_B4, 
                      palette_C1, palette_C2, palette_C3, palette_C4,
                      palette_D1, palette_D2, palette_D3, palette_D4);  
        }
    }
}

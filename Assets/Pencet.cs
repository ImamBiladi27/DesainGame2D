using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pencet : MonoBehaviour
{

    public int heart,super_heart;
    public enum vote { High };
    public char Karakter;
    public vote karakter;
    public string Text;
    string myText;
    public Vector2 Koordinat2D;
    public Vector3 Koordinat3D;

    // Start is called before the first frame update
    void Start()
    {
        if(karakter == vote.High)
        {
            myText = "High";
        }
        else
        {
            myText = "Low";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGui()
    {
        GUILayout.BeginArea(new Rect(10, 10, 200, 200));
        GUILayout.Label("Heart: " + heart.ToString());
        GUILayout.Label("Super Heart" + super_heart.ToString());
        GUILayout.Label("Tulisan : " + Text.ToString());
        GUILayout.Label("Komentar : " + myText.ToString());
        //GUILayout.Label("@D")
        GUILayout.Label("2D : " + Koordinat2D.ToString());
        GUILayout.Label("3D : " + Koordinat3D.ToString());
        GUILayout.EndArea();
    }
}

using UnityEngine;  
using System.Collections;  
public class DataType : MonoBehaviour {  
      public int heart;  
      public int super_heart;  
      
      public string Text;  
      public int treshold=100;
 
    public int konversi;
    public int invest;
    public int total_invest;
    string myText,myText2;
    public int token=50;
    public int return_invest;
        public int total_return;
    public int multyple_return;
    public int hasil_return;
      void Start () {
         konversi = 12;
        invest = konversi * 2 * super_heart;

        total_invest = invest + heart;
        if (total_invest < treshold)
        {
            myText = "Low";
        }
        else
        {
            myText = "High";
        }
        return_invest = 4;
        total_return = token * return_invest;
        multyple_return = 6;

        if (total_return < (total_invest * multyple_return))
        {
            myText2 = "Low";
        }
        else
        {
            myText2 = "High";
        }
       }  
    
       void Update () {  
       }  
       void OnGUI(){  
	           GUILayout.BeginArea(new Rect(10,100,300,300));

                GUILayout.Label("Heart: "+heart.ToString());  
	           GUILayout.Label("Super_Heart: "+super_heart.ToString());
       
        GUILayout.Label("konversi value(super heart= 2*value*heart): " + konversi.ToString());
        GUILayout.Label("invest: " + invest.ToString());
        GUILayout.Label("total invest: " + total_invest.ToString());
        GUILayout.Label("Termasuk kategori : " + myText.ToString());
        GUILayout.Label("Program Return");
        GUILayout.Label("Return(Token) : "+token.ToString());
        GUILayout.Label("Penyetaraan nilai return invest(token = 2*heart) : " + return_invest.ToString());
        GUILayout.Label("Total Return(setara Heart) : " + total_return.ToString());
        GUILayout.Label("Multyple Return Invest : "+multyple_return.ToString());
        GUILayout.Label("Termasuk kategori : " + myText2.ToString());
        GUILayout.EndArea();  
	      }  
}  

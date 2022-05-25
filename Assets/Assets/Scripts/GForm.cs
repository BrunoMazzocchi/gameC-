using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking; 
using UnityEngine.UI; 
public class GForm : MonoBehaviour
{
     [SerializeField] InputField correo, name, lastName; 
     [SerializeField] private ToggleGroup tg1,tg2; 
     private Button button; 
     string URL = "https://docs.google.com/forms/u/2/d/e/1FAIpQLSc5ee9cp6pT-gPShNa0N1jjlAjmkdxGNzNkUE_pe5UeOx_C0g/formResponse"; 

     public void Send() 
     { 
        string x = tg1.GetFirstActiveToggle().name; 
        string y = tg2.GetFirstActiveToggle().name; 


        string correo1 = correo.text;
        string name1 = name.text;
        string lastName1 = lastName.text;



         StartCoroutine (Post (correo1, name1, lastName1, x, y) ) ; 


     } 

     IEnumerator Post(string correo, string name, string lastName, string a,string b) 
     { 
         WWWForm form = new WWWForm(); 
         form.AddField ("entry.891023532", correo); 
         form.AddField ("entry.406804439", name); 
         form.AddField ("entry.1059391456", lastName); 
         form.AddField ("entry.1584919580", a); 
         form.AddField ("entry.341093581", b); 
        
         UnityWebRequest www = UnityWebRequest.Post(URL, form); 

         yield return www.SendWebRequest(); 
         GameObject.Find("buttonName").GetComponentInChildren<Text>().text = "Enviado";
         yield return new WaitForSeconds(0.5f); 
         
         Application.Quit();

     }
}

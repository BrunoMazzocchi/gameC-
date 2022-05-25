using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsController : MonoBehaviour
{
    public GameObject[] elementos; 
    private int counter; 
    public GameObject mobo; 
    public GameObject PSU; 
    public GameObject proc; 
    public GameObject graphicCard; 
    public GameObject ssd; 
    public GameObject ram; 
    public GameObject cooler; 
    public GameObject casePC; 
    public GameObject grassBox;
    public GameObject canvas; 
    public AudioSource tickSource; 
    public AudioSource tickSource2; 

    private void OnTriggerEnter2D(Collider2D other){
       if(other.CompareTag("pc1")){
           counter = counter + 1; 
           PlayerController.instance.contador = counter; 
           tickSource.Play();
           mobo.SetActive(false);
       }
              if(other.CompareTag("pc2")){
           counter = counter + 1; 
           PlayerController.instance.contador = counter; 
           tickSource.Play();
           proc.SetActive(false);
       }
              if(other.CompareTag("pc3")){
           counter = counter + 1; 
           PlayerController.instance.contador = counter; 
           tickSource.Play();
           cooler.SetActive(false);
       }
              if(other.CompareTag("pc4")){
           counter = counter + 1; 
           PlayerController.instance.contador = counter; 
           tickSource.Play();
           casePC.SetActive(false);
       }
              if(other.CompareTag("pc5")){
           counter = counter + 1; 
           PlayerController.instance.contador = counter;
           tickSource.Play(); 
           PSU.SetActive(false);
       }
              if(other.CompareTag("pc6")){
           counter = counter + 1; 
           PlayerController.instance.contador = counter; 
           ram.SetActive(false);
           tickSource.Play();
       }
              if(other.CompareTag("pc7")){
           counter = counter + 1; 
           PlayerController.instance.contador = counter; 
           tickSource.Play();
           graphicCard.SetActive(false);
       }
              if(other.CompareTag("pc8")){
           counter = counter + 1; 
           PlayerController.instance.contador = counter; 
           tickSource.Play();
           ssd.SetActive(false);
       }
       if(other.CompareTag("PCPart")){
           grassBox.SetActive(false);
       }

 if(counter == elementos.Length){
           canvas.SetActive(true);
           tickSource2.Play();
       }
   }


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

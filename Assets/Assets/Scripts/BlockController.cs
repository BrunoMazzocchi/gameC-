using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public static BlockController instance; 

    public SpriteRenderer theSR; 
    public Sprite bOn, bOff; 
    public GameObject mobo; 

    public void Awake( ){
        instance = this; 
    }
   private void OnTriggerEnter2D(Collider2D other){

       if(theSR.sprite != bOff){
       if(other.CompareTag("Player")){

           theSR.sprite = bOff; 
           mobo.SetActive(true);
       }
       }
   }
}

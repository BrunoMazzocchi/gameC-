using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnOffController : MonoBehaviour
{

     private void OnTriggerEnter2D(Collider2D other){
       if(other.CompareTag("Player")){
          if(CameraController.instance.stopFollow == false){
              CameraController.instance.stopFollow = true; 
          } else if (CameraController.instance.stopFollow == true){
              CameraController.instance.stopFollow = false; 
          }
       }
   }
  
}

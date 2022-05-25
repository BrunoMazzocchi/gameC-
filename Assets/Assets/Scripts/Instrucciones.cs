using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Instrucciones : MonoBehaviour
{
public string startScene; 

 
    public void StartGame(){
        SceneManager.LoadScene(startScene);
    }

}

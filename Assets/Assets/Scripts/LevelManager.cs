 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance; 
    public float waitToRespawn; 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake(){
        instance = this; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespawnPlayer(){ 
        StartCoroutine(RespawnCo());


    }
    IEnumerator RespawnCo(){
        //Sirve para ejecutar codigo y esperar unos segundos. 
        PlayerController.instance.gameObject.SetActive(false);
        yield return new WaitForSeconds(waitToRespawn);

        PlayerController.instance.gameObject.SetActive(true);
        PlayerController.instance.transform.position = CheckPointController.instance.spawnPoint; 

        PlayerHealthController.instance.currentHealth = PlayerHealthController.instance.maxHealth; 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    public static CheckPointController instance; 
    public CheckPoint[] checkPoint; 
    public Vector3 spawnPoint; 

    void Awake()
    {
        instance = this; 
    }

    private void Start(){
        checkPoint = FindObjectsOfType<CheckPoint>();
        spawnPoint = PlayerController.instance.transform.position; 
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeactivateCheckpoints(){
        for(int i = 0; i < checkPoint.Length; i++){
            checkPoint[i].ResetCheckpoint();
        }
    }

    public void SetSpawnPoint(Vector3 newSpawnPoint){
        spawnPoint = newSpawnPoint; 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    public Transform target;

    public Transform farBackground, middleBackground, reallyFarBackground, mediumBackground, middleFarBackground;

    public float minHeight, maxHeight;

    private Vector2 lastPos;

    public bool stopFollow;


    public void setStopFollow()    {
        if(stopFollow == true){
            stopFollow = false; 
        }
    }
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        lastPos = transform.position;
    }

    void Update()
    {
        if(!stopFollow)
        {
            transform.position = new Vector3(target.position.x, Mathf.Clamp(target.position.y, minHeight, maxHeight), transform.position.z);

            Vector2 amountToMove = new Vector2(transform.position.x - lastPos.x, transform.position.y - lastPos.y);

            farBackground.position = farBackground.position + new Vector3(amountToMove.x, amountToMove.y, 0f);
            middleBackground.position += new Vector3(amountToMove.x, amountToMove.y, 0f) * .5f;
            middleFarBackground.position += new Vector3(amountToMove.x, amountToMove.y, 0f) * .5f;
            mediumBackground.position += new Vector3(amountToMove.x, amountToMove.y, 0f) * .3f;

            
            reallyFarBackground.position = reallyFarBackground.position + new Vector3(amountToMove.x, amountToMove.y, 0f);
            lastPos = transform.position;
        }
        
    }
}

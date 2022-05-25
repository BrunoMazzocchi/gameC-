using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance; 
    public int currentHealth, maxHealth; 

    public float invinsibleLength; 
    private float invinsibleCounter; 

    private SpriteRenderer theSR; 

    private void Awake(){ 
        instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; 
        theSR = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(invinsibleCounter > 0){ 
            invinsibleCounter -= Time.deltaTime; 
            if(invinsibleCounter<=0){
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 1f);

            }
        }
    }

    public void DealDamage()
    {
        if(invinsibleCounter <= 0){
            currentHealth--; 
        if(currentHealth <= 0)
        {
            currentHealth = 0; 

             LevelManager.instance.RespawnPlayer();
        } else {
            invinsibleCounter = invinsibleLength; 
            theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, .5f);
            PlayerController.instance.KnockBack( );
        }

        UIController.instance.UpdateHealthDisplay();
        }
    }

    public void AutoKill(){
        currentHealth = 0;
         if(currentHealth <= 0)
        {
            currentHealth = 0; 
            LevelManager.instance.RespawnPlayer(); 
        }
        UIController.instance.UpdateHealthDisplay();
    }
}

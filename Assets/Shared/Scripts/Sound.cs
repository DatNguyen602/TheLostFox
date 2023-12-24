using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sound : MonoBehaviour
{
    // Start is called before the first frame update
    
    static Sound instance;
    // Player sound
    public AudioClip jump;
    public AudioSource source;
    public AudioClip playerRun;
    public AudioClip playerHurt;
    public AudioClip playerHit;
   

    // Game sound
    public AudioClip backGroundMusic1;
    public AudioClip backGroundMusic2;
    public AudioClip backGroundMusic3;
    public AudioClip backGroundMusic4;


    // VFXSound
    public AudioClip bulletExplode;
    public AudioClip enemyDeath;




    public static Sound getInstance()
    {
        return instance;
    }
    
    
    void Start()
    {
        instance = this;
        PlaySenceSound();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void PlayJump() 
    {
        source.PlayOneShot(jump);
    }


    public void PlayPlayerRun() 
    {   
        source.PlayOneShot(playerRun);
    
    }


    public void PlayPlayerHit() 
    {
        source.PlayOneShot(playerHit);
    }

    public void PlaySenceSound()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        
        int sceneIndex = currentScene.buildIndex;
       

        switch (sceneIndex)
        {
            case 1:
                source.PlayOneShot(backGroundMusic1);
                break;
            case 2:
                source.PlayOneShot(backGroundMusic2);
                break;
            case 3:
                source.PlayOneShot(backGroundMusic3);
                break;
            default:
                source.PlayOneShot(backGroundMusic4);
                break;
        }

    }

    public void PlayShoot()
    {
        source.PlayOneShot(playerHit);
    }

    public void PlayExplode()
    {
        source.PlayOneShot(bulletExplode);
    }

    public void PlayeEnemyDeath()
    {
        source.PlayOneShot(enemyDeath);
    }

    public void PlayHurt()
    {
        source.PlayOneShot(playerHurt);
    }

}

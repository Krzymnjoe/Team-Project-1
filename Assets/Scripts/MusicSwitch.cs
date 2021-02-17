using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitch : MonoBehaviour
{

    public AudioSource LevelMusic;
    public AudioSource DeathMusic;
    public AudioSource VictoryMusic;

    public bool levelcheck;
    public bool deathcheck;
    public bool victorycheck;

    //COPY LINES INTO THE PLAYER SCRIPT TO USE THIS ONE PROPERLY
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BGMusic()
    {
        levelcheck = true;
        deathcheck = false;
        victorycheck = false;
        LevelMusic.Play();
    }

    public void DMusic()
    {
        if (LevelMusic.isPlaying)
            levelcheck = false;
        {
            LevelMusic.Stop();
        }
        if (!DeathMusic.isPlaying && deathcheck == false)
        {
            DeathMusic.Play();
            deathcheck = true;
        }
    }

    public void VMusic()
    {
        if (LevelMusic.isPlaying)
            levelcheck = false;
        {
            LevelMusic.Stop();
        }
        if (!VictoryMusic.isPlaying && victorycheck == false)
        {
            VictoryMusic.Play();
            victorycheck = true;
        }
    }
}


using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public int scoreCount;
    public Text scoreText;
    public Text highText;
    public AudioSource scoreSound;
    public AudioSource gameMusic;

    
  
        public void Awake()
        {
            instance = this;
        }

        public void Start()
        {
            scoreText.text = "Score: " + scoreCount;
            highText.text = "High Score: " + ((int)PlayerPrefs.GetFloat("High Score")).ToString();

        }

        public void addScore(int scoreToAdd)
        {
            scoreCount += scoreToAdd;
            scoreText.text = "Score: " + scoreCount;
            if (PlayerPrefs.GetFloat("High Score") < scoreCount)
                PlayerPrefs.SetFloat("High Score", scoreCount);
            scoreSound.Play();


        }
       

    } 

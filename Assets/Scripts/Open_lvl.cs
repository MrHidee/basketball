using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Open_lvl : MonoBehaviour
{
     public void PlayGame()
    {
        SceneManager.LoadScene("LevelChoose");
    }

}

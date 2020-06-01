using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{

	public void Restart()
	{
		SceneManager.LoadScene("Level");
	}
	public void Restart1()
	{
		SceneManager.LoadScene("Level1");
	}
	public void Restart2()
	{
		SceneManager.LoadScene("Level2");
	}
	public void Restart3()
	{
		SceneManager.LoadScene("Level3");
	}
}

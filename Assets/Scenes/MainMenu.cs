using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public Button PlayButton;
	public void PlayGame()
	{
		SceneManager.LoadScene("SceneARWatch");
	}
	public void QuitGame()
    {
		print("Quit Game!");
		Application.Quit();
    }
	//void Start()
	//{
	//	Button btn = PlayButton.GetComponent<Button>();
	//	btn.onClick.AddListener(TaskOnClick);
	//}

	//void TaskOnClick()
	//{
	//	Debug.Log("You have clicked the button!");
 //   }
}

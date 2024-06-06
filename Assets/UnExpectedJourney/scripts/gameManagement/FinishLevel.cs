using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour 
{
	public string LevelName;
	public void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.GetComponent<CharacterBehavior>() == null)
			return;
			
		//LevelManager.Instance.GotoLevel(LevelName);
		SceneManager.LoadScene("Level" + (SceneManager.GetActiveScene().buildIndex + 1));
	}


	void UnlocKNewLevel()
	{
		if(SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex")){
			PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
			PlayerPrefs.SetInt("UnlockNewLevel", PlayerPrefs.GetInt("UnlockNewLevel", 1) + 1);
			PlayerPrefs.Save();
		}
	}
}

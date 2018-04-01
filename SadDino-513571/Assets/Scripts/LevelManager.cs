using UnityEngine;
using UnityEngine.SceneManagement;		// Requiered to switch scenes
using System.Collections;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string name)
    {
        Debug.Log("New Level load: " + name);
        Application.LoadLevel(name);
    }
    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }
    public static void LoadNextLevel()
    {
        //   SceneManager.LoadScene(SceneManager.loadedScene + 1);
             Application.LoadLevel(Application.loadedLevel + 1);

    }

    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
  public void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void quitApp()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }
    public void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void menuScene()
    {
        SceneManager.LoadScene("Menu"); 
    }
}

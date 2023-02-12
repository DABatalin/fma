using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsFunc : MonoBehaviour
{
    public void StartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame() 
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void ShowLevels() 
    {
        SceneManager.LoadScene("LevelSelect");
    }
}

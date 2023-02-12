using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {   
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject screamer;
    public GameObject mainCamera;

    void Update() {
        if (Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene(0);
        }
    }


    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
        FindObjectOfType<AudioManager>().Play("win_sound");
    }

    public void GameOver(string deathType) {
        if (!gameHasEnded) {
            Debug.Log("Game over!");
            gameHasEnded = true;
            if (deathType == "fall") {
                mainCamera.GetComponent<PlayerFollow>().enabled = false;
                FindObjectOfType<AudioManager>().Play("wiiu");
            }
            if (deathType == "bagged") {
                screamer.SetActive(true);
                FindObjectOfType<AudioManager>().Play("screamer");
            }
            Invoke("Restart", restartDelay);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

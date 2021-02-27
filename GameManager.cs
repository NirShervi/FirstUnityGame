
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI , gameOverUI, enemy, player;
 
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            gameOverUI.SetActive(true);
            Invoke("Restart", restartDelay);
        }
    }

    public void RestartGame()
    {
        Invoke("Restart", 0.5f);
    }

    public void GameWon()
    {
        completeLevelUI.SetActive(true);
        Destroy(enemy);
        player.GetComponent<PlayerMovement>().enabled = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

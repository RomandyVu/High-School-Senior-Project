using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDectector : MonoBehaviour
{
    bool gameHasEnded = false;

 public void EndGame ()
    {
       if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("WHAT");
            Restart();
        }

    }
    void Restart ()
    {
        SceneManager.LoadScene("Menu");
    }

    public void CompleteLevel ()
    {
        Debug.Log("FORWARD");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

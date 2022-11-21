using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManger : MonoBehaviour
{
    bool gamehasEnded = false;
    public float restartDelay = 2f;
    public void EndGame()
    {
        if(gamehasEnded == false)
        {
            gamehasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

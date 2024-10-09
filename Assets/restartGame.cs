using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{
    public void resetGame()
    {
        SceneManager.LoadScene("Main_Game");
    }
}

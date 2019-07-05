using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Game_Manager : MonoBehaviour
{
    bool GameOver = false;
    public Text sctext;
     public void EndGame()
    {
        if (GameOver == false)
        {
            GameOver = true;
           // Debug.Log("Game Over!");
            sctext.text = "Game Over";
            Invoke("Restart", 2f);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

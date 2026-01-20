using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class LogicManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score=0;
    public Text textScore;
    public GameObject gameOver; 

    [ContextMenu("Increase score")]
    public void addScore()
    {
        score++;
        textScore.text = score.ToString();

    }

    public void restartGame() { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
    
    }

    public void gameover()
    {
        gameOver.SetActive(true);
    }
}

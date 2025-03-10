using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
public int playerScore;
private bool isGameOver = false; //Making sure no edge cases can add score after the birdy dies
public GameObject gameOverScreen;

public Text scoreText;
public Text highScoreText;
void Start()
    {
        highScoreDisplay();
    }
[ContextMenu("Increase score")]
public void addScore(int scoreToAdd){
   if (!isGameOver){
    playerScore += scoreToAdd;
    scoreText.text = playerScore.ToString();
                if (playerScore > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", playerScore);
                PlayerPrefs.Save();
                highScoreDisplay(); 
            }
    }
}

public void restartGame(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    isGameOver = false;
}
public void gameOver(){
    gameOverScreen.SetActive(true);
    isGameOver = true;
}
public void highScoreDisplay(){
    int highScore = PlayerPrefs.GetInt("HighScore", 0);
    highScoreText.text = highScore.ToString();
}
}

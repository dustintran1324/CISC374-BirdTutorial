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
[ContextMenu("Increase score")]
public void addScore(int scoreToAdd){
   if (!isGameOver){
    playerScore += scoreToAdd;
   }
    scoreText.text = playerScore.ToString();
}

public void restartGame(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    isGameOver = false;
}
public void gameOver(){
    gameOverScreen.SetActive(true);
    isGameOver = true;
}
}

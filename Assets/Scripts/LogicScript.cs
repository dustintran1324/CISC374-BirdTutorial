using UnityEngine;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
public int playerScore;
public Text scoreText;
[ContextMenu("Increase score")]
public void addScore(){
    playerScore += 1;
    scoreText.text = playerScore.ToString();
}
}

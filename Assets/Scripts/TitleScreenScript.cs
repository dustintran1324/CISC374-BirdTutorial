using UnityEngine;

public class TitleScreenScript : MonoBehaviour
{
    public GameObject titleScreen; 

    void Start()
    {
        Time.timeScale = 0; 
    }

    public void StartGame()
    {
        titleScreen.SetActive(false); 
        Time.timeScale = 1;
    }
}

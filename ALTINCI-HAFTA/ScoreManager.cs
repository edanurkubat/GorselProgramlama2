using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class ScoreManager : MonoBehaviour
{
  public TextMeshProUGUI scoreText;
  public GameObject gameOverScreen; // bitiş ekranu
  PickupManager pickups;  //sahnedeki kapsüllerin referansı

  int totalPickups; // sahnede olan kapsül sayısı
  int score = 0; // skor sayacı


  private void Start() 
  {
    pickups = FindFirstObjectByType<PickupManager>();
    totalPickups = pickups.amount;
    UpdateScore();
  }

public void CollectPickup()
{
  score++;
  UpdateScore();
  if (score >= totalPickups)
  {
    gameOverScreen.SetActive(true);
    Time.timeScale = 0f;
  }
}
  public void UpdateScore()
  {
    scoreText.text = "Skor: " + score.ToString();
  }
     
    public void RestartGame()
    {
       Time.timeScale = 1f;
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}

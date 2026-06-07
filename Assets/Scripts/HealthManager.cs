using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;

    public int maxHealth = 3;
    public int currentHealth;

    public GameObject[] healthIcons;

    public AudioSource audioSource;
    public AudioClip playerDeathSound;

    public GameObject gameOverText;
    bool isGameOver = false;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage()
    {
        currentHealth--;

        if (currentHealth >= 0)
        {
            healthIcons[currentHealth].SetActive(false);
        }

        if (currentHealth <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        isGameOver = true;

        if (audioSource != null && playerDeathSound != null)
        {
            audioSource.PlayOneShot(playerDeathSound);
        }

        if (gameOverText != null)
        {
            gameOverText.SetActive(true);
        }

        Time.timeScale = 0f;
    }

    public void KillPlayer()
    {
        currentHealth = 0;
        GameOver();
    }

    void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void Update()
    {
        if (isGameOver && Keyboard.current.rKey.wasPressedThisFrame)
        {
            RestartGame();
        }
    }

}
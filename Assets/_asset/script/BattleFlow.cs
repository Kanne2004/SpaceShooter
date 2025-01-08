using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace demo2d
{
    public class BattleFlow : MonoBehaviour
    {
        public GameObject gameWinUI;
        public GameObject gameOverUI;
        public PlayerHealth playerHealth;
        public GameObject bgMusic;



        // Start is called before the first frame update
        void Start()
        {
            gameOverUI.SetActive(false);
            gameWinUI.SetActive(false);
            playerHealth.onDead += OnGameOver;

        }

        // Update is called once per frame
        void Update()
        {
            if (playerHealth.healthPoint <= 0)
            {
                OnGameOver();
            }
            else if (EnemyHealth.LivingEnemyCount <= 0)
            {
                OnGameWin();
            }

        }
        private void OnGameOver()
        {
            gameOverUI.SetActive(true);
            bgMusic.SetActive(false);
        }

        private void OnGameWin()
        {
            gameWinUI.SetActive(true);
            bgMusic.SetActive(true);
            playerHealth.gameObject.SetActive(false);
        }
        public void ReturnToMainMenu() => SceneManager.LoadScene("MainMenu");

    }
}


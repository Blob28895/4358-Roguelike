using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameoverUI;

    public void RestartButton()
    {
        staticVariables.currHealth = Player.maxHealth;
        SceneManager.LoadScene("Level 1");
    }

    public void HomeButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ScientistFight()
    {
        staticVariables.currHealth = Player.maxHealth;
        SceneManager.LoadScene("ScientistFight");
    }
}
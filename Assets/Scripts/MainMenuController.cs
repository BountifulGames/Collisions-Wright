using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//////////////////////////////////////////////
//Assignment/Lab/Project: Collisions
//Name: Hunter Wright
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 3/25/2024
/////////////////////////////////////////////
public class MainMenuController : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuBackground;
    [SerializeField] private GameObject instructionsBackground;

    // Code for running the main menu UI
    public void OnPlayButtonPress()
    {
        SceneManager.LoadScene("Collisions");
    }

    public void OnInstructionsButtonPress()
    {
        mainMenuBackground.SetActive(false);
        instructionsBackground.SetActive(true);
    }

    public void OnQuitButtonPress()
    {
        Application.Quit();
    }

    public void OnBackButtonPress()
    {
        instructionsBackground.SetActive(false);
        mainMenuBackground.SetActive(true);
    }
}

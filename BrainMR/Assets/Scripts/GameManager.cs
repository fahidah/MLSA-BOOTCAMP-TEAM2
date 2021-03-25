﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject welcome, definition, parts, cerebrum, cerebellum, stem, frontal, temporal, occipital, parietal, brain;
    

    // Start Lesson
    public void startLesssonCLicked()
    {
        welcome.gameObject.SetActive(false);
        definition.gameObject.SetActive(true);
    }

    public void definitionDialog()
    {
        definition.gameObject.SetActive(false);
        parts.gameObject.SetActive(true);
    }

    public void partsDialog()
    {
        parts.gameObject.SetActive(false);
        cerebrum.gameObject.SetActive(true);
    }

    public void cerebrumDialog()
    {
        cerebrum.gameObject.SetActive(false);
        frontal.gameObject.SetActive(true);
    }

    public void cerebellumDialog()
    {
        cerebellum.gameObject.SetActive(false);
        stem.gameObject.SetActive(true);
    }
    public void stemDialog()
    {
        stem.gameObject.SetActive(false);
        brain.gameObject.SetActive(true);
    }
    public void frontalDialog()
    {
        frontal.gameObject.SetActive(false);
        parietal.gameObject.SetActive(true);
    }

    public void parietalDialog()
    {
        parietal.gameObject.SetActive(false);
        occipital.gameObject.SetActive(true);
    }
    public void occipitalDialog()
    {
        occipital.gameObject.SetActive(false);
        temporal.gameObject.SetActive(true);

    }
    public void temporalDialog()
    {
        temporal.gameObject.SetActive(false);
        cerebellum.gameObject.SetActive(true);
    }
    public void brainDialog()
    {
        brain.gameObject.SetActive(false);
    }


    //Load Learn Scene
    public void LearnScene(string name)
    {
        SceneManager.LoadScene("Learn Scene");
    }

    //Load Quiz Scene
    public void QuizScene(string name)
    {
        SceneManager.LoadScene("Quiz Scene");
    }

    //Load WELCOME Scene
    public void WelcomeScene(string name)
    {
        SceneManager.LoadScene("Welcome Scene");
    }

    //Reload Quiz Scene
    public void ReloadLearnScene(string name)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

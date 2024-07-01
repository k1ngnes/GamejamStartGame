using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Articy.Jam.GlobalVariables;

public class RespawnMenuUI : MonoBehaviour
{

    [SerializeField] private Button resetButton;
    [SerializeField] private Button toMenuButton;


    private void Awake()
    {
        resetButton.onClick.AddListener(() =>
        {
            ArticyGlobalVariables.Default.ResetVariables();
            Loader.Load(Loader.Scene.StartLevelScene);
        });
        toMenuButton.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.MainMenuScene);
        });
    }

}

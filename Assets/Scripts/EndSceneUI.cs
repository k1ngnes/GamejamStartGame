using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneUI : MonoBehaviour 
{


    [SerializeField] private Button toMenuButton;
    [SerializeField] private Button quitButton;


    private void Awake() 
    {
        toMenuButton.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.MainMenuScene);
        });
        quitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }

}

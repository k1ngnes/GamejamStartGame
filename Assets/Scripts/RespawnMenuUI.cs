using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RespawnMenuUI : MonoBehaviour
{

    [SerializeField] private Button resetButton;
    [SerializeField] private Button toMenuButton;


    private void Awake()
    {
        resetButton.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.Testing);
        });
        toMenuButton.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.MainMenuScene);
        });
    }

}

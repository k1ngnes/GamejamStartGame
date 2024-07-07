using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader 
{

    public enum Scene // names of Scene must match actual scenes
    {
        MainMenuScene,
        StartLevelScene,
        Level1Scene,
        Level1Hallway,
        Level1Room6,
        Level1Room7,
        Level1Room8,
        LoadingScene,
        RespawnScene,
        EndScene
    }

    private static Scene targetScene;

    public static void Load(Scene targetScene)
    {
        Loader.targetScene = targetScene;
        SceneManager.LoadScene(Scene.LoadingScene.ToString()); // loading loading scene
    }

    public static void LoaderCallback()
    {
        SceneManager.LoadScene(targetScene.ToString());
    }
}

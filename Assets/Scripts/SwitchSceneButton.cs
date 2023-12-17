using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchSceneButton : MonoBehaviour
{
    public Button Button;
    public int SceneTargetIndex;

    private void Start()
    {
        Button.onClick.AddListener(SwitchScene);
    }

    private void SwitchScene()
    {
        SceneManager.LoadScene(SceneTargetIndex);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    // Name of the scene to load
    public string nextSceneName = "NextScene";

    // Reference to the Button component
    public Button button;

    void Start()
    {
        if (button == null)
        {
            Debug.LogError("Please assign a Button component to this script!");
            return;
        }

        // Add listener to the button's onClick event
        button.onClick.AddListener(LoadNextScene);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}

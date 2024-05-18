using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    void Start()
    {
        Button button = GetComponent<Button>();

        button.onClick.AddListener(ExitGame);
    }

    void ExitGame()
    {
        Debug.Log("Exit game");
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTouch : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene("MenuPage");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitializeObj : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("IntroPage", LoadSceneMode.Single);
        Destroy(this);
    }
}

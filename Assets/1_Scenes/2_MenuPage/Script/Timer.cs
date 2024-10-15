using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text textTimeLeft;
    [SerializeField] float TimeLeft;
    [SerializeField] string DestinationScene;
    float curTimeLeft;

    void Start()
    {
        curTimeLeft = TimeLeft;
        textTimeLeft.text = ((int)curTimeLeft).ToString();
    }

    void Update()
    {
        if (Input.anyKey)
        {
            curTimeLeft = TimeLeft;
            Debug.Log("A key or mouse click has been detected");
        }
        else
            curTimeLeft -= Time.deltaTime;
        
        if(curTimeLeft <= 0)
        {
            SceneManager.LoadScene(DestinationScene);
            curTimeLeft = 0;
        }

        textTimeLeft.text = ((int)curTimeLeft).ToString();
    }
}

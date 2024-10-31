using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UITopButton : MonoBehaviour
{
    public static UITopButton instance;
    private int maxIndex = 5;
    public GameObject homeObj;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OnClickNext()
    {
        int currIndex = SceneManager.GetActiveScene().buildIndex;
        if (currIndex == maxIndex)
        {
            OnClickHome();
        }
        else
        {
            SceneManager.LoadScene(currIndex + 1);
            homeObj.SetActive(true);
        }
    }

    public void OnClickPre()
    {
        int currIndex = SceneManager.GetActiveScene().buildIndex;
        if (currIndex == 0)
        {
            Application.Quit();
        }
        else
        {
            SceneManager.LoadScene(currIndex-1);
            homeObj.SetActive(true);
        }
    }

    public void OnClickHome()
    {
        SceneManager.LoadScene(0);
        homeObj.SetActive(false);
    }
}

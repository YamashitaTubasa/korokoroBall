using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {

    }
    private int coinCount;
    public Text textComponent;
    private void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
        coinCount = 0;
    }
    public void SeneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void CangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    public void AddCoinCount()
    {
        coinCount = coinCount + 1;

        Debug.Log("CoimCount:" + coinCount);

        textComponent.text = "CoinCount : " + coinCount;
    }

}

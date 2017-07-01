using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckEnd : MonoBehaviour
{
    public int HousesToDestroy = 4;
    public Text VisualTime;
    private int HousesDestroyed = 0;

    private void Start()
    {
        HousesDestroyed = 0;
        GameInformation.Time = 0;
    }

    private void Update()
    {
        GameInformation.Time += Time.deltaTime;
        this.VisualTime.text = GameInformation.Time.ToString("F0");
    }

    public void DestroyHouse()
    {
        HousesDestroyed++;
        Debug.Log(HousesDestroyed);
        if (HousesDestroyed >= HousesToDestroy)
            GameOver();
    }

    public void GameOver()
    {
        StartCoroutine(LoadTitle());
    }

    IEnumerator LoadTitle()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("Title");
    }
}

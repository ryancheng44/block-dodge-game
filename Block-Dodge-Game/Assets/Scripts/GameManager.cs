using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float slowness = 10f;

    public void EndGame()
    {
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        Time.timeScale /= slowness;
        Time.fixedDeltaTime /= slowness;

        yield return new WaitForSeconds(Time.timeScale);

        Time.timeScale *= slowness;
        Time.fixedDeltaTime *= slowness;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

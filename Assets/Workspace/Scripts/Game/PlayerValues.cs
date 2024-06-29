using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerValues : MonoBehaviour
{
    public ValuesToSave Values;
    public string GameOverSceneName;

    private void Start()
    {
        Values.OnMoneyLessThanZero.AddListener(OnLose);
    }

    private void OnLose()
    {
        SceneChanger.LoadScene(GameOverSceneName);
    }
}

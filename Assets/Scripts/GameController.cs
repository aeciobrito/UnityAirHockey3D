using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    #region singleton
    private static GameController _instance;

    public static GameController Instance
    {
        get
        {
            if(_instance == null)
            {
                GameObject gameObject = new GameObject("GameController");
                gameObject.AddComponent<GameController>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    #endregion

    private int[] scorePoints = new int[2];

    public void Goal(int whoScored)
    {
        scorePoints[whoScored]++;
    }
}

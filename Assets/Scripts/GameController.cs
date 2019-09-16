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

    [SerializeField] GameObject _player0, _player1, _puck;

    private int[] scorePoints = new int[2];
    float startPosition = 1.2f;

    private void Start()
    {

    }

    public void Goal(int whoScored)
    {
        scorePoints[whoScored]++;
        ResetPositions(whoScored);
    }

    public void ResetPositions(int whoIsTheTurn)
    {
        _player0.transform.position = _player0.GetComponent<Paddle>().StartPosition;
        _player0.GetComponent<Rigidbody>().velocity = Vector3.zero;

        //_player1.transform.position = _player1.GetComponent<Paddle>().StartPosition;
        //_player1.GetComponent<Rigidbody>().velocity = Vector3.zero;

        _puck.GetComponent<Rigidbody>().velocity = Vector3.zero;
        _puck.gameObject.transform.position = new Vector3(0, 0, startPosition * (whoIsTheTurn == 0 ? 1 : -1));

    }
}

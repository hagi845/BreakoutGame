using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    private int _currentBlockNum;

    public GameObject GameOverDialog;
    public GameObject ClearDialog;

    public GameObject Ball;

    public int BlockNum = 36;

    public static BlockManager Instance { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        _currentBlockNum = BlockNum;
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        GameOverDialog.SetActive(true);
        Destroy(Ball);
    }

    public void BlockBreak()
    {
        _currentBlockNum--;
        if(_currentBlockNum == 0)
        {
            ClearDialog.SetActive(true);
            Destroy(Ball);
        }
    }
}

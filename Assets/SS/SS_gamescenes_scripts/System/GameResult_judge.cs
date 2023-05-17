using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ゲームの終了時に勝敗をジャッジするスクリプト
public class GameResult_judge : MonoBehaviour
{
    //変数judgementを参照することで勝敗を格納する
    public bool judgement;

    private void Start()
    {
        judgement = false;
    }
}

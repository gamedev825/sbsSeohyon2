using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void OnEnable()
    {
        // 이벤트 구독
        PlayerController.OnGameOver += RespondToGameOver;
    }

    private void OnDisable()
    {
        // 이벤트 구독 해제
        PlayerController.OnGameOver -= RespondToGameOver;
    }

    void RespondToGameOver()
    {
        Debug.Log("EnemyController : 플레이어 사망, patrol 전환");
    }
}

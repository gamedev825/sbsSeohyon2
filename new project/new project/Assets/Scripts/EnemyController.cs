using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void OnEnable()
    {
        // �̺�Ʈ ����
        PlayerController.OnGameOver += RespondToGameOver;
    }

    private void OnDisable()
    {
        // �̺�Ʈ ���� ����
        PlayerController.OnGameOver -= RespondToGameOver;
    }

    void RespondToGameOver()
    {
        Debug.Log("EnemyController : �÷��̾� ���, patrol ��ȯ");
    }
}

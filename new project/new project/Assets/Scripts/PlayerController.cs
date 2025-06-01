using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //��������Ʈ�� �̺�Ʈ ����
    public delegate void GameOverEvent();
    public static event GameOverEvent OnGameOver;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("PlayerController : 'G' ��ư�� ������ ���� ���� " );    
    }

    // Update is called once per frame
    void Update()
    {
        // 'G' Ű�� ������ ���� ���� �̺�Ʈ �߻�
        if (Input.GetKeyDown(KeyCode.G))
        {
            TriggerGameOver();
        }

    }

    void TriggerGameOver()
    {
        Debug.Log("PlayerController : ���� ���� ");
        if(OnGameOver != null)
        {
            OnGameOver(); //�̺�Ʈ ȣ��
        }
    }
}

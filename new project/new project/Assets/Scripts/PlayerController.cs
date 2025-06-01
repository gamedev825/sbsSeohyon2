using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //델리게이트와 이벤트 선언
    public delegate void GameOverEvent();
    public static event GameOverEvent OnGameOver;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("PlayerController : 'G' 버튼을 누르면 게임 오버 " );    
    }

    // Update is called once per frame
    void Update()
    {
        // 'G' 키를 누르면 게임 오버 이벤트 발생
        if (Input.GetKeyDown(KeyCode.G))
        {
            TriggerGameOver();
        }

    }

    void TriggerGameOver()
    {
        Debug.Log("PlayerController : 게임 오버 ");
        if(OnGameOver != null)
        {
            OnGameOver(); //이벤트 호출
        }
    }
}

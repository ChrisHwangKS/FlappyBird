using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(480, 800, false);
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 좌클릭시 y축으로 300만큼 점프 
        if(Input.GetMouseButtonDown(0)) 
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            gameObject.GetComponent<Rigidbody>().AddForce(0, 250, 0);
        }

        // R버튼 누를시 게임 초기화 및 재시작
        if(Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Game");
        }
    }

    // 충돌시 게임 오버
    void OnCollisionEnter(Collision coll)
    {
        Time.timeScale = 0;
    }
}

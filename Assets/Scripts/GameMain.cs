using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMain : MonoBehaviour
{
    void Awake()
    {
       // 初始化一些东西

       Debug.Log("GameMain Awake");

       GameObject.DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        // 加载游戏内容
        SceneManager.LoadScene("Loddy", LoadSceneMode.Single);

        

        Debug.Log("GameMain Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

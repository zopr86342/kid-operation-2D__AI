using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //引用 介面 API

public class F2 : MonoBehaviour {
    //定義列舉
    //修飾詞 列舉 列舉名稱{ 列舉內容,.... }
    public enum state
    {
        //一般、尚未完成、完成
        normal, notcomplete, comptele
    }
    //使用列舉
    //修飾詞 類型 名稱
    public state _state;

    [Header("開頭對話")]
    public string sayStart = "嗨~你這隻死狐狸";
    [Header("說話速度")]
    public float sayspeed = 1.0f;
    [Header("是否完成任務")]
    public bool task = false;
    [Header("完成任務對話")]
    public string sayComptele = "挖啊~你怎麼這麼棒";
    [Header("任務失敗務對話")]
    public string sayNotComptele = "你這小廢物";
    [Header("玩家取得道具數量")]
    public int playerProp = 0;
    [Header("道具需求數量")]
    public int countProp = 0;
    public Text textSay;
    
    
    



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

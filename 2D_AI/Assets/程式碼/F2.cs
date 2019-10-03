using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F2 : MonoBehaviour {
    [Header("開頭對話")]
    public string saystart = "嗨~你這隻死狐狸";
    [Header("說話速度")]
    public float sayspeed = 1.0f;
    [Header("是否完成任務")]
    public bool task = false;
    [Header("完成任務對話")]
    public string goodtask = "挖啊~你怎麼這麼棒";
    [Header("任務失敗務對話")]
    public string badtask = "你這小廢物";
    [Header("玩家取得道具數量")]
    public int playerProp = 0;
    [Header("道具需求數量")]
    public int countProp = 0;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

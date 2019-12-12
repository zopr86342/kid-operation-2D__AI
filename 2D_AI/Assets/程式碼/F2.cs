using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //引用 介面 API

public class F2 : MonoBehaviour {
    public AudioClip soundSay;
    private AudioSource aud;
    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }
    #region 欄位
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
    [Header("介面")]
    public GameObject objCanvas;
    public Text textSay;
    #endregion

    //2D觸發事件
    private void OnTriggerEnter2D(Collider2D collision)
    {    //如果碰到物件為"狐狸"
        if(collision.name == "狐狸")
        Say();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "狐狸")
          SayClose();
        
    }
    /// <summary>
    /// 對話:打字效果
    /// </summary>
    private void Say()
    {
        //畫布.顯示
        objCanvas.SetActive(true);
        StopAllCoroutines();
        if (playerProp >= countProp) _state = state.comptele;
        
        //判斷式(狀態)
        switch (_state)
        {
            case state.normal:
                StartCoroutine(ShowDialog(sayStart));       //開始對話
                _state = state.notcomplete;
                break; 
            case state.notcomplete:
                StartCoroutine(ShowDialog(sayNotComptele)); //開始對話未完成
                break; 
            case state.comptele:
                StartCoroutine(ShowDialog(sayComptele));    //開始對話完成
                break; 

        }

    }
    private IEnumerator ShowDialog(string say)
    {
        textSay.text = "";
        for (int i = 0; i < say.Length; i++)
        {
            textSay.text += say[i].ToString();
            aud.PlayOneShot(soundSay, 1.5f);
            yield return new WaitForSeconds(sayspeed);
        }
        
    }
    /// <summary>
    /// 關閉對話
    /// </summary>
    private void SayClose()
    {
        StopAllCoroutines();
        objCanvas.SetActive(false);
    }
    /// <summary>
    /// 玩家取得道具
    /// </summary>
    public void PlayerGet()
    {
        countProp++;
    }






	
}

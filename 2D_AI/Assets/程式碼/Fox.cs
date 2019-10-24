
using UnityEngine;                //引用 Unity API- API=>倉庫 功能、工具

public class Fox : MonoBehaviour  //類別 類別名稱
{
    //成員:欄位、屬性、方法、事件
    //欄位的組成=>修飾詞 類型 名稱 指定 值 ;
    public int foxspeed = 50;          //整數
    public float jump = 2.5f;          //浮點數
    public string foxName = "狐狸";    //字串
    public bool pass = false;          //布林值 true/false
    private Rigidbody2D rig;
    private Transform tra;
   
    //事件:在特定時間點會以指定頻率執行的方法
    //開始事件:遊戲開始時執行一次(下面的
    private void Start()
    {   //泛型<T>
        rig = GetComponent<Rigidbody2D>();
        tra = GetComponent<Transform>();
        


        // 下面這個API是輸出訊息到Unity的各種類別,
        //Debug.Log("薰嗣一生推^o^/");   //文字
       // Debug.LogError("錯誤訊息");    //錯誤訊息
       // Debug.LogWarning("警告訊息");  //警告訊息
       // Debug.Log(5.3f);  //浮點數
       // Debug.Log(false); //布林質
       // Debug.Log(53);    //數字

    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) tra.eulerAngles =new Vector3(0,180,0);
        if (Input.GetKeyDown(KeyCode.D)) transform.eulerAngles = new Vector3(0, 0, 0);//這裡的tra也可不用宣告上面的private Transform tra;(下面繼續
                                                                                      //直接transform.eulerAngles = new Vector3(0, 0, 0);這樣也行
    }
    private void FixedUpdate()  //固定更新事件每禎0.002秒
    {
       // Debug.Log(Input.GetAxis("Horizontal"));
        rig.AddForce(new Vector2(foxspeed * Input.GetAxis("Horizontal"), 0));
          
    }
}

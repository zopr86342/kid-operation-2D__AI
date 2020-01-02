
using UnityEngine;

public class LearnLerp : MonoBehaviour {

    //插值: 取兩個值之間的位置
    //0 與 10 中間 50%
    //插值(0,10,0.5f) => 5
    public Transform cubeA, cubbeB;
    public float speed = 1;
    private void Start()
    {
        print(Mathf.Lerp(0, 100, 0.5f));
    }
    private void Update()
    {
        cubeA.position = Vector3.Lerp(cubeA.position, cubbeB.position, 0.3f * Time.deltaTime * speed);
    }
}

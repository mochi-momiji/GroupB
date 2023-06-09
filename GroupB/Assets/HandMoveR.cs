using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMoveR : MonoBehaviour
{

    double timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) 
        {
            handmove();
        }
    }

    void handmove()
    {
        //経過時間のカウント
        timer += Time.deltaTime;

        //4秒間のループ
        double t = timer % 4;

        if (t < 1.0f || t > 3.0f)//2秒経過するまで上移動
        {
            transform.Translate(-0.01f, 0.01f, 0.0f);
        }
        else if (t < 3.0f)//4秒経過するまで下移動
        {
            transform.Translate(0.01f, -0.01f, 0.0f);
        }

    }
}

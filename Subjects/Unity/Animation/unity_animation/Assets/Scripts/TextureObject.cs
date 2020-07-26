using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureObject : ObjectsBase
{
    private Animator animator = null;

    override protected void Start()
    {
        base.Start();

        animator = this.GetComponent<Animator>();

        if (animator == null)
        {
            Debug.Log("Animatorが見つかりません");
        }
    }

    override protected void Update()
    {
        base.Update();

        if (animator == null)
        {
            return;
        }

        // テスト用、移動はアニメーションで設定
        //MoveX();

        // 一定時間でジャンプをするように設定
        if (Time.frameCount % 5 == 0)
        {
            TriggerOn("Jump");
        }
    }

    private void MoveX()
    {
        var trans = this.transform.position;
        trans.x += 1;
        this.transform.position = trans;
    }

    private void TriggerOn(string key)
    {
        if (animator == null)
        {
            return;
        }

        animator.SetTrigger(key);
    }
}

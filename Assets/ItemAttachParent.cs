using UnityEngine;

public class ItemAttachParent : MonoBehaviour
{
    // ゲームオブジェクトがぶつかったとき
    public void OnTriggerEnter(Collider other)
    {
        // ぶつかったゲームオブジェクトのコリジョンのレイヤーの種類を文字列にする
        string layerName = LayerMask.LayerToName(other.gameObject.layer);

        if (other.gameObject.tag == "sushi")
        {
            // ぶつかったゲームオブジェクト（かばんを想定）を親ゲームオブジェクトにする
            this.transform.SetParent(other.gameObject.transform);
            // Rigidbodyを取得し、ゲームオブジェクトが物理設定で動かないようにする
            Rigidbody rb = this.transform.GetComponent<Rigidbody>();
            rb.isKinematic = true;
        }
    }

    // ゲームオブジェクトがプレイヤーに握られたとき
    public void ExitGrab()
    {
        // 親ゲームオブジェクトを空にして独立させる
        this.gameObject.transform.parent = null;
        // Rigidbodyを取得し、ゲームオブジェクトが物理設定で動くようにする
        Rigidbody rb = this.transform.GetComponent<Rigidbody>();
        rb.isKinematic = false;
    }
}
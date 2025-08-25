using Oculus.Interaction;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public GameObject Prehub;
    private OVRGrabbable grabbable;

    void Start()
    {
        grabbable = GetComponent<OVRGrabbable>();
        // もしこのスクリプトがPrehubにアタッチされている場合は以下に変更
        // grabbable = Prehub.GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (grabbable != null && grabbable.isGrabbed == true)
        {
            Debug.Log("つかまれた");
        }
        else
        {
            Debug.Log("つかまれてない");
        }
    }
}

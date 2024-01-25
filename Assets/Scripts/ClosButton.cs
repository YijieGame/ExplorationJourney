using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosButton : MonoBehaviour
{
    [SerializeField] Transform myParent;
    public void onclicked()
    {
        myParent.localScale = new Vector3(0, 0, 0);
    }
}

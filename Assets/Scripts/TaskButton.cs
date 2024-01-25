using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskButton : MonoBehaviour
{
    [SerializeField] Transform clue, info, checkmark;
    [SerializeField] int taskNum;

    private void Start()
    {
        info.localScale = new Vector3(0, 0, 0);
        checkmark.localScale = new Vector3(0, 0, 0);
        clue.localScale = new Vector3(0, 0, 0);
    }

    private void Update()
    {
        if (Main.nowTask >= taskNum)
        {
            checkmark.localScale = new Vector3(80, 13.7f, 0);
        }
        else
        {
            checkmark.localScale = new Vector3(0, 0, 0);
        }
    }

    public void onclicked()
    {
        if(Main.nowTask >= taskNum)
        {
            info.localScale = new Vector3(144, 24.6f, 0);
            clue.localScale = new Vector3(0, 0, 0);
        }
        else
        {
            info.localScale = new Vector3(0, 0, 0);
            checkmark.localScale = new Vector3(0, 0, 0);
            clue.localScale = new Vector3(144, 24.6f, 0);
        }
    }

}

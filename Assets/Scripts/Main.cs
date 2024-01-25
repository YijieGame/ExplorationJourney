using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    Button btStart, btChangeLanguage;
    public static int nowTask = 0;
    [SerializeField] Transform menuPage, mainPage, successPage, clue1, clue2, clue3, clue4, clue5, info1, info2, info3, info4, info5, tsk1, tsk2, tsk3, tsk4, tsk5, cmr,detect;
    // Start is called before the first frame update
    void Start()
    {
    }
    public void btStartOnclick()
    {
        menuPage.localScale = new Vector3(0, 0, 0);
        mainPage.localScale = new Vector3(145.2f, 152, 140.6f);
        successPage.localScale = new Vector3(0, 0, 0);
    }

    public void cameraOnclicked()
    {
        detect.localScale = new Vector3(2,2,2);
        /*StartCoroutine("showSuccess");*/
        System.Threading.Thread.Sleep(Random.Range(800, 2500));
        detect.localScale = new Vector3(0, 0, 0);
        nowTask++;
        successPage.localScale = new Vector3(147, 147, 147);
        cmr.localScale = new Vector3(0, 0, 0);
        tsk1.localScale = new Vector3(0, 0, 0);
        tsk2.localScale = new Vector3(0, 0, 0);
        tsk3.localScale = new Vector3(0, 0, 0);
        tsk4.localScale = new Vector3(0, 0, 0);
        tsk5.localScale = new Vector3(0, 0, 0);
    }

    IEnumerable showSuccess()
    {
        detect.localScale = new Vector3(0, 0, 0);
        nowTask++;
        successPage.localScale = new Vector3(147, 147, 147);
        cmr.localScale = new Vector3(0, 0, 0);
        tsk1.localScale = new Vector3(0, 0, 0);
        tsk2.localScale = new Vector3(0, 0, 0);
        tsk3.localScale = new Vector3(0, 0, 0);
        tsk4.localScale = new Vector3(0, 0, 0);
        tsk5.localScale = new Vector3(0, 0, 0);

        yield return new WaitForSeconds(Random.Range(0.5f, 2));
    }

    public void continueOnClicked()
    {
        successPage.localScale = new Vector3(0, 0, 0);
        cmr.localScale = new Vector3(1.5f, 8.2f, 1);
        tsk1.localScale = new Vector3(1, 5.85f, 1);
        tsk2.localScale = new Vector3(1, 5.85f, 1);
        tsk3.localScale = new Vector3(1, 5.85f, 1);
        tsk4.localScale = new Vector3(1, 5.85f, 1);
        tsk5.localScale = new Vector3(1, 5.85f, 1);
    }
}

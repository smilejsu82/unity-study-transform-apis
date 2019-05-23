using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InverseTransformPoint : MonoBehaviour
{
    public GameObject cubeA;
    public GameObject cubeB;

    // Start is called before the first frame update
    void Start()
    {
        //Transform.InverseTransformPoint
        //https://docs.unity3d.com/ScriptReference/Transform.InverseTransformPoint.html   

        //트랜스폼의 월드 좌표를 로컬 좌표로 변환 
        //Transform.TransformPoint(로컬좌표를 월드 좌표로 변환)의 반대 
        //스케일에 영향을 받음 
        //방향을 다룬다면 Transform.InverseTransformDirection을 쓸것

        var relative = this.cubeA.transform.InverseTransformPoint(this.cubeB.transform.position);
        Debug.LogFormat("relative: {0}", relative);
        //cubeB가 A로부터 2,0,0 에 위치해있다는것을 알수 있다.
        //cubeA 의 스케일을 0.2, 0.2, 0.2로 변경한다면 결과값은 10, 0, 0이 나온다.
        //값이 안나온다면 스케일을 의심하자 
        //반대로 cubeB의 스케일이 변해도 결과 값은 변하지 않는다.
    }
}

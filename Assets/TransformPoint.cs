using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPoint : MonoBehaviour
{
    public GameObject cubeA;
    public GameObject cubeB;

    // Start is called before the first frame update
    void Start()
    {
        //Transform.TransformPoint
        //https://docs.unity3d.com/ScriptReference/Transform.TransformPoint.html
        //로컬좌표를 월드 좌표로 변환 
        //스케일에 영향을 받으니 주의 
        //방향을 다룬다면 Trasnform.TransformDirection을 사용할것 
        //반대로 월드 공간좌표를 로컬좌표로 변환하고자 한다면 Transform.InverseTransformPoint사용할것

        //this.CreateCube1();
        this.CreateCube2();

    }

    private void CreateCube1()
    {
        // cubeA의 오른쪽 2지점에 새로운 오브젝트를 생성하고자 한다.
        var pos = cubeA.transform.TransformPoint(Vector2.right * 2);
        Debug.LogFormat("pos: {0}", pos);

        //방법1
        //Instantiate(this.cubeB, pos, this.cubeB.transform.rotation);

        //방법2
        var newCube = Instantiate(this.cubeB);//, this.cubeB.transform.rotation);
        newCube.transform.position = pos;
    }

    private void CreateCube2()
    {
        var pos = this.cubeA.transform.TransformPoint(2, 0, 0);
        Instantiate(this.cubeB, pos, this.cubeB.transform.rotation);
    }
}

using UnityEngine;

public class BaseMovement : IMoveable 
{
    private Transform objTransform;

    public BaseMovement(Transform t) 
    {
        objTransform = t;
    }

    public void Move() 
    {
        float x = Mathf.PingPong(Time.time * 2f, 5f);
        objTransform.position = new Vector3(x, objTransform.position.y, objTransform.position.z);
    }
}
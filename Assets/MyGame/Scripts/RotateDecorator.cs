using UnityEngine;

public class RotateDecorator : MovementDecorator 
{
    private Transform objTransform;

    public RotateDecorator(IMoveable inner, Transform t) : base(inner) 
    {
        objTransform = t;
    }

    public override void Move() 
    {
        base.Move();
        objTransform.Rotate(Vector3.up * 100f * Time.deltaTime);
    }
}
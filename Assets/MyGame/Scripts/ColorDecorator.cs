using UnityEngine;

public class ColorDecorator : MovementDecorator 
{
    private Material mat;

    public ColorDecorator(IMoveable inner, Material m) : base(inner) 
    {
        mat = m;
    }

    public override void Move() 
    {
        base.Move();
        mat.color = Color.Lerp(Color.red, Color.blue, Mathf.PingPong(Time.time, 1f));
    }
}
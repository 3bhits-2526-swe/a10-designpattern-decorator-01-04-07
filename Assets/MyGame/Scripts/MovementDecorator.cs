public abstract class MovementDecorator : IMoveable 
{
    protected IMoveable wrappee;

    public MovementDecorator(IMoveable inner) 
    {
        wrappee = inner;
    }

    public virtual void Move() 
    {
        wrappee.Move();
    }
}

public abstract class Model
{
    public abstract void Initialize();
    public abstract void Save();
    public virtual void OnCreate() { }
    public virtual void OnStart() { }
}

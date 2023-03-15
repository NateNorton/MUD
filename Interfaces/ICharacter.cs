interface ICharacter 
{
    public string Name { get; protected set; }
    public Position position { get; protected set; }

    public void Move();
}
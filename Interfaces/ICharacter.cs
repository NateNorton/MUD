interface ICharacter 
{
    string Name { get; protected set; }
    Position position { get; protected set; }

    void Move();
}
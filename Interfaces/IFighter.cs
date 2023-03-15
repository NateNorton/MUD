interface IFigher 
{
    int Health { get; set; }
    int Level { get; set; }

    // TODO: Adjust return type to something sensible
    public void Attack();
}
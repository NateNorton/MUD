namespace Mud 
{
    // An interface for generating and presenting descriptions
    interface IDescription 
    {
        // Generate a description of the entity
        // TODO: Is this needed?
        void GenerateDescription();
        // Provide/Output the description of the entity
        void Describe();

    }
}
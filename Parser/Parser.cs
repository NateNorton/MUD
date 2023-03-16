namespace Mud 
{
    public class Parser
    {
        /* These are auto-implemented for now...
        public Parser() {}
        ~Parser() {}
        */

        // Produce a List<string> of lowercase tokens from an input string
        // Split on whitespace, ignore empty strings
        public List<string> Tokenize(string input)
        {
            List<string> tokens = new List<string>();
            foreach (string? token in input.Split()) 
            {
                if (!System.String.IsNullOrWhiteSpace(token))
                    {
                        tokens.Add(token.ToLower()); 
                    }
            }
            return tokens;
        } 
    }
}
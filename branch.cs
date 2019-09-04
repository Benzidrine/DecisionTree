namespace TreeBasedMachineLearningAlgorithms_1
{
    public class branch
    {
        public int ID {get;set;}
        // The Branch above this one - 0 is the initial branch 
        public int ParentID {get;set;}
        // Attribute to make a decision by
        public string DecisionAttribute {get; set;}
        // A leaf is a decision that ends in a pure subset - All the results have the same outcome
        public bool Leaf {get;set;}
        // Depth is the number of branches above - Useful for defining a maximum depth to a Tree
        public int depth {get; set;}
        // Matched Data 
        string[,] MatchedData {get; set;}
        // Unmatched Data 
        string[,] UnmatchedData {get; set;}

    }
}
using System.Collections.Generic;

namespace TreeBasedMachineLearningAlgorithms_1
{
    public class DecisionTree
    {
        public string[,] data {get;set;}
        private List<int> AttributeIndexes = new List<int>();
        private int OutcomeIndex {get;set;}
        // Label of outcome column
        private string outcomeLabel {get;set;}

        public void build()
        {
            // Check for empty
            if (data.GetLength(0) == 0)
                return;
            // Get Attribute Indexes from tree - First row assumed to be labels
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[0,1] != outcomeLabel)
                {
                    AttributeIndexes.Add(i);
                }
                else
                {
                    OutcomeIndex = i;
                }
            }
            // Build Code
            int lastBranch = 0;
            // Work Queue number of data items at first and then each item in a pure subset is removed from it
            int WorkQueue =  data.GetLength(1);
            // While data is not in a pure subset
            while (WorkQueue > 0)
            {
                // Set Node to leaf if all the same
            }
        }

        // Check if all outcomes are the same
        public bool CheckOutcomesAreTheSame (string[,] data)
        {
            bool TheSame = true;
            string CheckValue = data[1,OutcomeIndex];
            for (int i = 2; i < data.GetLength(1); i++)
            {
                if (CheckValue != data[1,OutcomeIndex])
                {
                    TheSame = false;
                }
            }
            return TheSame;
        }
    }
}
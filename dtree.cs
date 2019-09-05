using System.Collections.Generic;
using System.Linq;

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
            // Current Depth
            // While data is not in a pure subset
            while (WorkQueue > 0)
            {
                // Set Node to leaf if all the same



                // Find splitting attribue by largest one
                Dictionary<string, int> attributeCounter = new Dictionary<string, int>();
                string LargestAttribute = "";
                int LargestAttributeCount = 0;
                int LargestAttributeIndex = 0; 
                // Loop through each column
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    // If not the outcome column
                    if (i != OutcomeIndex)
                    {
                        attributeCounter =  new Dictionary<string, int>();
                        // Loop through each row
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            if (!attributeCounter.ContainsKey(data[i,j]))
                                attributeCounter.Add(data[i,j],1);
                            else
                            {
                                attributeCounter.TryGetValue(data[i,j], out var currentCount); 
                                attributeCounter[data[i,j]] = currentCount + 1;
                            }
                        }
                        // Check Attribute contains more than one item
                        if (attributeCounter.Count > 1)
                        {
                            // Find largest attribute so far and record it
                            if (attributeCounter.Values.Max() > LargestAttributeCount)
                            {
                                LargestAttributeCount = attributeCounter.Values.Max();
                                LargestAttribute = attributeCounter.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                                LargestAttributeIndex = i;
                            }
                        }
                    }
                }
                // Add new branch based on splitting attribute 
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
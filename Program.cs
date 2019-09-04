/// Author: Taran Marley
/// Copyright (c) 2019 Taran Marley
///
/// Licensed under the Apache License, Version 2.0 (the "License").
/// You may not use this file except in compliance with the License.
/// You may obtain a copy of the License at
///   http://www.apache.org/licenses/LICENSE-2.0
///
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS,
/// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
/// implied.  See the License for the specific language governing
/// permissions and limitations under the License.

using System;

namespace TreeBasedMachineLearningAlgorithms_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create multi-dimensional array of example data
            string[,] data = new string[6,3] {
                {"Name", "Gender", "Born"},
                {"William", "male", "Germany"},
                {"Louise", "female", "Texas"},
                {"Minnie", "female", "Texas"},
                {"Emma", "female", "Texas"},
                {"Henry", "male", "Germany"}
            };

            string outcomeLabel = "Born";

            Console.WriteLine("Hello World!");
        }
    }
}

// Copyright 2010-2018 Google LLC
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// [START program]
using System;
using Google.OrTools.Graph;

public class MaxFlowApi
{
  static void Main()
  {
    // [START data]
    // Define three parallel arrays: start_nodes, end_nodes, and the capacities
    // between each pair. For instance, the arc from node 0 to node 1 has a
    // capacity of 20.
    // From Taha's 'Introduction to Operations Research',
    // example 6.4-2.

    int numNodes = 5;
    int numArcs = 9;
    int[] start_nodes = {0, 0, 0, 1, 1, 2, 2, 3, 3};
    int[] end_nodes = {1, 2, 3, 2, 4, 3, 4, 2, 4};
    int[] capacities = {20, 30, 10, 40, 30, 10, 20, 5, 20};
    // [END data]

    // [START constraints]
    // Instantiate a SimpleMaxFlow solver.
    MaxFlow maxFlow = new MaxFlow();
    // Add each arc.
    for (int i = 0; i < numArcs; ++i)
    {
      int arc = maxFlow.AddArcWithCapacity(start_nodes[i], end_nodes[i],
                                           capacities[i]);
      if (arc != i) throw new Exception("Internal error");
    }
    int source = 0;
    int sink = numNodes - 1;
    // [END constraints]

    // [START solve]
    // Find the maximum flow between node 0 and node 4.
    int solveStatus = maxFlow.Solve(source, sink);
    // [END solve]

    // [START print_solution]
    Console.WriteLine("Solving max flow with " + numNodes + " nodes, and " +
                      numArcs + " arcs, source=" + source + ", sink=" + sink);
    if (solveStatus == MaxFlow.OPTIMAL)
    {
      Console.WriteLine("Max. flow: " + totalFlow);
      Console.WriteLine("");
      Console.WriteLine("  Arc     Flow / Capacity");
      for (int i = 0; i < numArcs; ++i)
      {
        Console.WriteLine(maxFlow.Tail(i) + " -> " +
                          maxFlow.Head(i) + "    " +
                          string.Format("{0,3}", maxFlow.Flow(i)) + "  /  " +
                          string.Format("{0,3}", maxFlow.Capacity(i)));
      }
    }
    else
    {
      Console.WriteLine("Solving the max flow problem failed. Solver status: " +
                        solveStatus);
    }
    // [END print_solution]
  }
}
// [END program]

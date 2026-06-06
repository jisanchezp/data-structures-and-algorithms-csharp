using System.Diagnostics;
using ADSLib;
using DataStructuresAndAlgorithms.Services;

var ints = In.ReadInts("Inputs/1Kints.txt").ToArray();
var watch = new Stopwatch();
watch.Start();
var triples = ThreeSum.Count(ints);

Console.WriteLine($"Triples are {triples}");
Console.WriteLine($"Elapsed time {watch.Elapsed:g}");
watch.Stop();
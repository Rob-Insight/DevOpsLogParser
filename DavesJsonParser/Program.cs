// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DavesJsonParser.Models;
using System.Text.Json;

if (args == null || args.Length == 0)
{
    Console.WriteLine("Must provide json file path");
    Environment.Exit(13);
}


var fileObj = new List<AzDOExport>();
string fileRaw;
using (var sr = new StreamReader(args[0]))
{
    // Read the stream as a string, and write the string to the console.
    fileRaw = sr.ReadToEnd();
}
//Console.WriteLine("Len = " + fileRaw.Length.ToString());
fileObj = JsonSerializer.Deserialize<List<AzDOExport>>(fileRaw);
if (fileObj == null) Environment.Exit(17);
foreach (var item in fileObj)
{
    Console.WriteLine("ID: " + item.codeReviewId.ToString());
    Console.WriteLine("Close Date: " + item.closedDate.ToString());
    Console.WriteLine("Create By: " + item.createdBy.displayName);
    Console.WriteLine("Approvers:");
    foreach (var Ritem in item.reviewers)
    {
        if (Ritem.vote == 10 && !Ritem.displayName.StartsWith("[eReserve]"))
        {
            Console.WriteLine("...." + Ritem.displayName);
        }
    }
}
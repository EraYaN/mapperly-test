// See https://aka.ms/new-console-template for more information

#define HAVE_SETTERS

using System.Text.Json;
using MapperlyTest;
using MapperlyTest.Models;
using MapperlyTest.Protos;

Console.WriteLine("Starting...");


var i = new InputModel();
i.Names.Add("Name1");
i.Names.Add("Name2");

i.SubMessages.Add(new SubMessage { Name = "Sub1", Number = 1 });
i.SubMessages.Add(new SubMessage { Name = "Sub2", Number = 2 });

i.Numbers.Add(1);
i.Numbers.Add(2);

var ii = i.ToInternalInput();

// do request

var io = new Output();
io.Input = ii;

io.OutValues.Add(true);
io.OutValues.Add(false);

var o = io.ToExternalOutput();

Console.WriteLine("Simulated roundtrip request output...");

Console.WriteLine(JsonSerializer.Serialize(o, new JsonSerializerOptions() { WriteIndented = true }));

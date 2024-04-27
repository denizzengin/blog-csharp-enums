// See https://aka.ms/new-console-template for more information
using EnumsSample;

Console.WriteLine("Hello, World!");

StudentType studentTypeNone = StudentType.Unknown;
int studentTypeNoneUnderlyingValue = (int)studentTypeNone;

StudentType studentTypePrimary = StudentType.Primary;
StudentType studentTypeCollege = StudentType.College;

StudentType groupedType =  studentTypeNone | studentTypePrimary | studentTypeCollege ;
Console.WriteLine($"{groupedType}");

Console.WriteLine(groupedType.HasFlag(StudentType.Univertsity));

Console.WriteLine($"{studentTypeNone:d} {studentTypePrimary:d} {studentTypeCollege:d}");

Console.ReadLine();
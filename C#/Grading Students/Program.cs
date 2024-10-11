static List<int> gradingStudents(List<int> grades)
{
    for (int i = 0; i < grades.Count; i++)
    {
        if (grades[i] < 38)
        {
            continue;
        }
        int nextMultiple = ((grades[i] / 5) + 1) * 5;
        if (nextMultiple - grades[i] < 3)
        {
            grades[i] = nextMultiple;
        }
    }
    return grades;

}
List<int> grades = new List<int>() { 73, 67, 38, 33 };

Console.WriteLine(string.Join(", ", gradingStudents(grades)));
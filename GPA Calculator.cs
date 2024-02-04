
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

// Variables for each course grade
int course1Grade = 4;
int course2Grade = 3;
int course3Grade = 3;
int course4Grade = 3;
int course5Grade = 4;

// GPA calculation
int course1Score = course1Grade * course1Credit;
int course2Score = course2Grade * course2Credit;
int course3Score = course3Grade * course3Credit;
int course4Score = course4Grade * course4Credit;
int course5Score = course5Grade * course5Credit;

int totalScore = course1Score + course2Score + course3Score + course4Score + course5Score;
int totalCredit = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

decimal gpa = (decimal) totalScore / totalCredit;
int leadingDigit = (int) gpa;
int firstDigit = (int) (gpa * 10) % 10;
int secondDigit = (int) (gpa * 100) % 10;

// OUTPUT
Console.WriteLine(
$@"Student: {studentName}

Course           Grade   Credit Hours
{course1Name}          {course1Grade}      {course1Credit}
{course2Name}          {course2Grade}      {course2Credit}
{course3Name}          {course3Grade}      {course3Credit}
{course4Name}   {course4Grade}      {course4Credit}
{course5Name}       {course5Grade}      {course5Credit}

Final GPA:           {leadingDigit}.{firstDigit}{secondDigit}"
);


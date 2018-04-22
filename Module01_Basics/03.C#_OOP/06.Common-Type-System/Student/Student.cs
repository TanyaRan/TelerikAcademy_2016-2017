using System;
using System.Text;
//01.Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
//   mobile phone, e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. 
//   Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
//02.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a 
//   new object of type Student.
//03.Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
//   and by social security number (as second criteria, in increasing order).

public class Student : ICloneable, IComparable<Student>
{
    private string firstName;
    private string middleName;
    private string lastName;
    private string ssn;
    private string address;
    private string phoneNumber;
    private string email;
    private int course;
    private UniSpecialties? specialty;
    private Universities? university;
    private Faculties? faculty;

    public Student(string firstName, string middleName, string lastName, string ssn)
        : this(firstName, middleName, lastName, ssn, null, null, null, 0, null, null, null)
    {
    }

    public Student(
        string firstName, string middleName,
        string lastName, string ssn,
        string address, string phoneNumber,
        string email, int course,
        UniSpecialties? specialty,
        Universities? university,
        Faculties? faculty)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SSN = ssn;
        this.Address = address;
        this.PhoneNumber = phoneNumber;
        this.Email = email;
        this.Course = course;
        this.Specialty = specialty;
        this.University = university;
        this.Faculty = faculty;
    }

    // props 
    public string FirstName
    {
        get
        { return this.firstName; }
        set
        { this.firstName = value; }
    }

    public string MiddleName
    {
        get
        { return this.middleName; }
        set
        { this.middleName = value; }
    }

    public string LastName
    {
        get
        { return this.lastName; }
        set
        { this.lastName = value; }
    }

    public string SSN
    {
        get
        { return this.ssn; }
        set
        { this.ssn = value; }
    }

    public string Address
    {
        get
        { return this.address; }

        set
        { this.address = value; }
    }

    public string PhoneNumber
    {
        get
        { return this.phoneNumber; }
        set
        { this.phoneNumber = value; }
    }

    public string Email
    {
        get
        { return this.email; }
        set
        { this.email = value; }
    }

    public int Course
    {
        get
        { return this.course; }
        set
        { this.course = value; }
    }

    public UniSpecialties? Specialty
    {
        get
        { return this.specialty; }

        set
        { this.specialty = value; }
    }

    public Universities? University
    {
        get
        { return this.university; }

        set
        { this.university = value; }
    }

    public Faculties? Faculty
    {
        get
        { return this.faculty; }

        set
        { this.faculty = value; }
    }

    // methods
    public static bool operator ==(Student firstStudent, Student secondStudent)
    {
        return firstStudent.SSN == secondStudent.SSN;
    }

    public static bool operator !=(Student firstStudent, Student secondStudent)
    {
        return firstStudent.SSN != secondStudent.SSN;
    }

    public object Clone()
    {
        return new Student(
            this.FirstName,
            this.middleName,
            this.LastName,
            this.SSN,
            this.Address,
            this.PhoneNumber,
            this.Email,
            this.Course,
            this.Specialty,
            this.University,
            this.Faculty) as object;
    }

    public int CompareTo(Student stud)
    {
        if (this.FirstName.CompareTo(stud.FirstName) != 0)
        {
            return this.FirstName.CompareTo(stud.FirstName);
        }
        else if (this.MiddleName.CompareTo(stud.MiddleName) != 0)
        {
            return this.MiddleName.CompareTo(stud.MiddleName);
        }
        else if (this.LastName.CompareTo(stud.LastName) != 0)
        {
            return this.LastName.CompareTo(stud.LastName);
        }
        else if (this.SSN.CompareTo(stud.SSN) != 0)
        {
            return this.SSN.CompareTo(stud.SSN);
        }
        else
        {
            return 0;
        }
    }

    public override bool Equals(object obj)
    {
        Student student = obj as Student;

        if (this.SSN != student.SSN)
        {
            return false;
        }

        return true;
    }

    public override int GetHashCode()
    {
        int hashCode = this.SSN.GetHashCode() ^ this.LastName.GetHashCode() ^ this.FirstName.GetHashCode();
        return hashCode;
    }

    public override string ToString()
    {
        StringBuilder resultText = new StringBuilder();

        resultText.AppendFormat("----------------Student info-----------------\n");
        resultText.AppendFormat("First Name: {0} \n", this.FirstName);
        resultText.AppendFormat("Middle Name: {0} \n", this.MiddleName);
        resultText.AppendFormat("Last Name: {0} \n", this.LastName);
        resultText.AppendFormat("SNN : {0} \n", this.SSN);
        if (this.Address != null)
        { resultText.AppendFormat("Address: {0} \n", this.Address); }
        if (this.PhoneNumber != null)
        { resultText.AppendFormat("Phone number : {0} \n", this.PhoneNumber);  }
        if (this.Email != null)
        { resultText.AppendFormat("Email: {0} \n", this.Email); }
        if (this.Course != 0)
        { resultText.AppendFormat("Course: {0} \n", this.Course);  }
        if (this.Specialty != null)
        { resultText.AppendFormat("Specialty: {0} \n", this.Specialty); }
        if (this.University != null)
        { resultText.AppendFormat("University: {0} \n", this.University); }
        if (this.Faculty != null)
        { resultText.AppendFormat("Faculty: {0} \n", this.Faculty); }
        resultText.AppendFormat("-  -  -  -  -  -  -  -  -  -  -  -  -  - \n");

        return resultText.ToString();
    }
}

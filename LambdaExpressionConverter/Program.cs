
using System.Collections.ObjectModel;
using System.Linq.Expressions;


public class PatientDto
{
    public string Name { get; set; }
    public int Id { get; set; }
}

public class Patient
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string HealthCard { get; set; }
    public string VersionCode { get; set; }

}

public class Student
{
    public string ClassName { get; set; }

    public Guid StudentId { get; set; }

}

public class StudentDto
{
    public string ClassName { get; set; }

    public Guid StudentId { get; set; }

}


public class LamdbaExpressionConverter<TSource, TTarget> : ExpressionVisitor
{
    private ReadOnlyCollection<ParameterExpression> _parameterExpressions;

    public Expression<Func<TTarget, bool>> Convert(Expression expression)
    {
        return (Expression<Func<TTarget, bool>>)Visit(expression);
    }

    protected override Expression VisitLambda<T>(Expression<T> node)
    {

        _parameterExpressions = VisitAndConvert<ParameterExpression>(node.Parameters, "LamdbaExpressionConverter");

        return Expression.Lambda(Visit(node.Body), _parameterExpressions);
    }

    protected override Expression VisitParameter(ParameterExpression node)
    {
        if (node.Type == typeof(TSource))
        {

            var parameterExpression = _parameterExpressions?.FirstOrDefault(p => p.Name == node.Name);
            if (parameterExpression == null)
            {
                if (node.Type == typeof(TSource))
                {
                    return Expression.Parameter(typeof(TTarget), node.Name);
                }
                else
                {
                    return node;
                }
            }
            else
                return parameterExpression;

        }

        return base.VisitParameter(node);
    }

    protected override Expression VisitMember(MemberExpression node)
    {
        if (node.Member.DeclaringType == typeof(TSource) && typeof(TTarget).GetProperty(node.Member.Name) != null)
        {

            return Expression.MakeMemberAccess(Visit(node.Expression), typeof(TTarget).GetProperty(node.Member.Name));
        }
        return base.VisitMember(node);
    }

}

class Program
{
    static void Main(string[] args)
    {

        List<Patient> patientsFromDb = new List<Patient>
        {
            new()
            {
                Name = "Magic",
                Id = 4,
            },
            new()
            {
                Name="Johnson",
                Id= 5,
            }
        };

        List<Student> studentsFromDb = new List<Student>
        {
            new()
            {
               StudentId = new Guid("55ed2bc6-05be-4345-a726-347a21e13f7d"),
               ClassName = "Test"
            },
            new()
            {
               StudentId = new Guid("ff8726c9-5d76-427d-a20d-843a7afff3fe"),
               ClassName = "Test2"
            }

        };

        Expression<Func<PatientDto, bool>> lambdaExpression = patient => patient.Id == 4 && patient.Name == "Magic";

        var modifiedExpression = new LamdbaExpressionConverter<PatientDto, Patient>().Convert(lambdaExpression);
        //var modifiedExpression = (Expression<Func<Patient,bool>>)lambdaVisitor.Modify(lambdaExpression);
        var result = patientsFromDb.Where(modifiedExpression.Compile()).FirstOrDefault().Name;
        Console.WriteLine(result);

        Expression<Func<StudentDto, bool>> anotherLambdaExpression = student => student.ClassName == "Test";

        var modifiedExpression2 = new LamdbaExpressionConverter<StudentDto, Student>().Convert(anotherLambdaExpression);

        var result2 = studentsFromDb.Where(modifiedExpression2.Compile()).FirstOrDefault().StudentId;
        Console.WriteLine(result2);

    }
}


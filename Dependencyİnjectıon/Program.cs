using Dependencyİnjectıon;

public class Program
{
    public static void Main(string[] args)
    {

        IOgretmen teacher = new Teacher("Ali", "Yılmaz");
        ClassRoom classRoom = new ClassRoom(teacher);
        Console.WriteLine(classRoom.GetTeacherInfo());
    }
}

# Dependency Injection Örneği

Bu proje, **Dependency Injection** kullanımını göstermek için C# dilinde basit bir örnek içerir. Örnek, bir `Teacher` (Öğretmen) ve bir `ClassRoom` (Sınıf) nesnesi etrafında şekillenmiştir.

## Proje Yapısı

- **`IOgretmen` Arayüzü**: Bir öğretmenin sahip olması gereken `FirstName`, `LastName` gibi özellikleri ve `GetInfo()` metodunu tanımlar.
- **`Teacher` Sınıfı**: `IOgretmen` arayüzünü uygular ve bir öğretmenin adını ve soyadını temsil eder.
- **`ClassRoom` Sınıfı**: Yapıcı metodunda bir `IOgretmen` bağımlılığı alır ve öğretmen bilgilerini döndürmek için bu bağımlılığı kullanır.
- **`Program` Sınıfı**: Projenin `Main` metodunu içerir ve sınıfların nasıl kullanılacağını gösterir.

## Nasıl Çalışır?

1. `ClassRoom` sınıfı, bir `IOgretmen` bağımlılığına ihtiyaç duyar ve bu bağımlılığı yapıcı metodunda alır.
2. `Teacher` sınıfı, `IOgretmen` arayüzünün bir uygulamasıdır ve öğretmen bilgilerini sağlar.
3. `GetTeacherInfo()` metodu, `Teacher` sınıfının `GetInfo()` metodunu çağırarak öğretmen bilgilerini döndürür.

## Gereksinimler

- Visual Studio (güncel bir sürüm)
- .NET 6 veya daha yeni bir sürüm

## Başlangıç

1. **Projeyi Klonlayın**:
   ```bash
   git clone <repository-url>
   ```

2. **Projeyi Visual Studio'da Açın**:
   - Klonladığınız klasöre gidin.
   - `.sln` dosyasını açın.

3. **Projeyi Çalıştırın**:
   - `Ctrl + F5` tuşlarına basarak projeyi çalıştırabilirsiniz.

## Örnek Çıktı

Projeyi çalıştırdığınızda aşağıdaki çıktı ekranda görünecektir:

```
Öğretmen: Ali Yılmaz
```

## Kod Örnekleri

### `IOgretmen` Arayüzü
```csharp
public interface IOgretmen
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string GetInfo();
}
```

### `Teacher` Sınıfı
```csharp
public class Teacher : IOgretmen
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Teacher(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string GetInfo()
    {
        return $"Öğretmen: {FirstName} {LastName}";
    }
}
```

### `ClassRoom` Sınıfı
```csharp
public class ClassRoom
{
    private readonly IOgretmen _teacher;

    public ClassRoom(IOgretmen teacher)
    {
        _teacher = teacher;
    }

    public string GetTeacherInfo()
    {
        return _teacher.GetInfo();
    }
}
```

### `Program` Sınıfı
```csharp
public class Program
{
    public static void Main(string[] args)
    {
        IOgretmen teacher = new Teacher("Ali", "Yılmaz");
        ClassRoom classRoom = new ClassRoom(teacher);
        Console.WriteLine(classRoom.GetTeacherInfo());
    }
}
```

## Dependency Injection'ın Avantajları

- Sınıflar arasında gevşek bağlılık sağlar.
- Kodun test edilebilirliğini ve sürdürülebilirliğini artırır.
- Karmaşık uygulamalar için daha iyi ölçeklenebilirlik sağlar.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır.

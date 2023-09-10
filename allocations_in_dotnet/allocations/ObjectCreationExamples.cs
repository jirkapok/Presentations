namespace allocations;

public class ObjectCreationExamples
{
    public static void Create_Class()
    {
        var cA = new ClassA { P1 = 1 };
    }

    public static void Create_Struct()
    {
        var sA = new StructA { P1 = 2 };
    }

    public static void Create_Record()
    {
        var cA = new RecordA { P1 = 1 };
    }

    public static void Create_RecordStruct()
    {
        var sA = new RecordStructA { P1 = 2 };
    }
}
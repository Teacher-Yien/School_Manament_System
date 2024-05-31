namespace FielC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Binary write file
            //FileStream file = new FileStream("example.txt", FileMode.Create);
            //BinaryWriter binaryWriter = new BinaryWriter(file);
            using (FileStream fs = new FileStream("binaryfile.dat", FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    int intValue = 42;
                    double doubleValue = 3.14159;
                    string stringValue = "Hello, world!";
                    writer.Write(intValue);
                    writer.Write(doubleValue);
                    writer.Write(stringValue);
                }
            }
            // Binary Read file
           // FileStream fileStream = new("example.txt", FileMode.Open);
            //StreamReader streamReader = new StreamReader(fileStream);
            using (FileStream fs = new FileStream("binaryfile.dat", FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    int intValue = reader.ReadInt32();
                    double doubleValue = reader.ReadDouble();
                    string stringValue = reader.ReadString();
                    Console.WriteLine(
                    $"int: {intValue}, double: {doubleValue}, string: {stringValue}");
                }
            }
            Console.ReadKey();

        }
    }
}

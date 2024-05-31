// See https://aka.ms/new-console-template for more information
public class MenuBank
{
    public string Title { get; set; } = "";
    public List<Menu> Menues { get; set; } = new();

    public void Show()
    {
        Console.WriteLine($"[{Title} menu]");
        for(int k=0; k<Menues.Count; k++)
        {
            var menu = Menues[k];
            Console.WriteLine($"{k + 1,3}-{menu.Text}");
        }
    }
    public Menu GetMenu(string leading="")
    {
        int begin = 1;
        int end = Menues.Count;
    repeat:
        Console.Write($"{leading}Option?({begin}-{end}): ");
        if (int.TryParse(Console.ReadLine(), out var input) == false)
        {
            Console.WriteLine($"{leading}>Invalid format of input");
            goto repeat;
        }
        if (input < begin || input > end)
        {
            Console.WriteLine($"{leading}>Your input is {input}, th input index must be in [{begin}, {end}]");
            goto repeat;
        }
        return Menues[input - 1];

    }
}

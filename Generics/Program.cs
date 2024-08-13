
using System.Numerics;

public class Program
{


    public static void Main(string[] args) {

        Console.WriteLine(Add(7,2));








        //var list = new GenericList<int>();
        //list.Add(1);
        //list.Add(2);
        //list.Add(3);
        //list.Remove(1);
        //var count = list.Count;


    }

    public static T Add<T>(T num1 , T num2) where T : INumber<T>  // constrain T must be number
    {  return num1+num2; }


public class GenericList<T> : WaitHandle where T : class , new() // => it make a constrain that the T must be refrence type and have parameterless constractor
{
    private readonly List<T> _items =new();  

    public void Add(T item) {  _items.Add( item); }

    public void Remove(T item) { _items.Remove(item); }

    public int Count { get { return _items.Count; } }


}
}
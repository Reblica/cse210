public class Program
{
    static void Main(string[] args)
    {
        int code = 0;
        int _dial = 50;

        foreach (string rotation in System.IO.File.ReadAllLines("Combination.txt"))
        {
            char[] chars = ['R', 'L'];
            string[] numbers = rotation.Split(chars);
            char direction = rotation.First();
            int distance = int.Parse(numbers[1]);

            int[] newDial = RotateDial(direction, distance, _dial);
            code += newDial[1];
            _dial = newDial[0];

            if (_dial == 0 && newDial[1] == 0)
            {
                code++;
            }
        }
        Console.WriteLine(code);
    }

    static int[] RotateDial(char direction, int distance, int _dial)
    {
        int zero = 0;
        if (direction == 'L')
        {
            _dial -= distance;

            while (_dial < 0)
            {
                _dial += 100;
                zero++;
            }
        }
        else if (direction == 'R')
        {
            _dial += distance;

            while (_dial > 99)
            {
                _dial -= 100;
                zero++;
            }
        }
        int[] stuff = [_dial, zero];
        return stuff;
    }
}
using System;

namespace variant1
{
    class Account
    {
        public string Name { get; set; }
        public int number { get; set; }
        public double Summ { get; set; }
        public Account() { }
        public void Input()
        {
            Console.Write("Название счёта");
            this.Name = Console.ReadLine();

            Console.Write("номер счёта");
            this.number = Convert.ToInt32( Console.ReadLine());

            Console.Write("сумма счёта");
            this.Summ = Convert.ToDouble(Console.ReadLine());
        }
        public override string ToString()
        {
            return string.Format("Название счёта {0} номер счёта {1} сумма счёта {2}", Name, number, Summ);
        }
    }
}
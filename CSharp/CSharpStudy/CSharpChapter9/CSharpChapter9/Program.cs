using System;

namespace CSharpChapter9
{
    //1.다음 코드에서 메소드들을 프로퍼티로 변경하세요
    class NameCard
    {
        private int age;
        private string name;
        public int GetAge() { return age; }
        public void SetAge(int value) { age = value; }
        public string GetName() { return name; }
        public void setName(string value) { name = value; }
    }

    class PropertyNameCard
    {
        public int Age
        {
            get;
            set;
        } = 0;
        public string Name
        {
            get;
            set;
        } = "길동";
    }


    class Program
    {
        static void Main(string[] args)
        {
            //PropertyNameCard Mycard = new PropertyNameCard();
            //Mycard.Age = 24;
            //Mycard.Name = "상현";
            //Console.WriteLine("나이 : {0} ", Mycard.Age);
            //Console.WriteLine("이름 : {0} ", Mycard.Name);



            //2. 다음과 같은 결과를 출력하시오. 단, 무명형식을 이용해야합니다.

            var nameCard = new { Name = "박상현", Age = 17 };
            Console.WriteLine("이름:{0}, 나이:{1}", nameCard.Name, nameCard.Age);
            var complex = new { Real = 3, Imaginary = 12 };
            Console.WriteLine("Real: {0}, Imaginary: {1}", complex.Real, complex.Imaginary);
        }
    }
}

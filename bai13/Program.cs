using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    class Program
    {
        // Nhập vào 1 chuỗi sau đó : 
        // đếm xem có bao nhiêu chữ in hoa,in thường,số,khoảng trắng.
        static void Xulychuoi()
        {
            int CountUpper = 0, CountLower = 0, CountNumber = 0, CountSpace = 0;
            string S;
            Console.WriteLine("input your string: ");
            S = Console.ReadLine();
            char[] array = S.ToArray();
            for(int i = 0; i<array.Length; i++)
            {
                // char Charracters = S[i];
                if (char.IsLower(array[i]))
                    CountLower++;
                if (char.IsUpper(array[i]))
                    CountUpper++;
                if (char.IsDigit(array[i]))
                    CountNumber++;
                if (char.IsWhiteSpace(array[i]))
                    CountSpace++;
            }
            Console.WriteLine("Have {0} lowercase ", CountLower);
            Console.WriteLine("Have {0} uppercase", CountUpper);
            Console.WriteLine("Have {0} alphanumeric characters", CountNumber);
            Console.WriteLine("Have {0} characters spaces", CountSpace);
            Console.ReadLine();
        }
        static void XuLyChuoi2()
        {
            Console.WriteLine("Input your first string: ");
            string S1 = Console.ReadLine();
            Console.WriteLine("Input your second string: ");
            string S2 = Console.ReadLine();
            int Result = S1.ToLower().CompareTo(S2.ToLower()); // phải cùng định dạng để so sánh 2 chuỗi giống nhau nhưng 1 chuỗi hoa 1 chuỗi thường
            if (Result == 0)
                Console.WriteLine("S1 same S2");
            else if (Result == 1)
                Console.WriteLine("S1 is greater than s2");
            else
                Console.WriteLine("S1 is lesser than s2");
            Console.ReadLine();
        }
        static void XuLyChuoi3()
        {
            string s = string.Format("{0:dd/mm/yyyy hh::mm:ss}", DateTime.Now);
            Console.WriteLine(s);
            Console.ReadLine();
        }
        static void XuLyChuoi4()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "D:/baihat/nhactre/ngay mai se khac.mp3";
            int vt = s.LastIndexOf("/");
            string TenBh = s.Substring(vt + 1); // chạy từ kí tự "/" đến hết
            int vt2 = TenBh.LastIndexOf("."); // trả về vị trí của kí tự "."
            String TenBh2 = TenBh.Substring(0, vt2); // bắt đầu từ kí tự thứ 0 đến vt2
            Console.WriteLine(TenBh);
            Console.WriteLine(TenBh2);
            Console.ReadLine();
        }
        static void XuLyChuoi5()    
        {
            string s = " Do Thanh    Loc  ";
            s = s.Trim();
            Console.WriteLine(s);
            
            s = s.ToUpper();
            Console.WriteLine(s);
            Console.ReadLine();
        }
        static void XuLyChuoi6()
        {
            string str = "mot,hai,ba";
            string[] str2 = str.Split(',');
            Console.WriteLine(str2[0]);
            Console.WriteLine(str2[1]);
            Console.WriteLine(str2[2]);
            Console.ReadLine();
        }
        // xóa các khoảng trắng dư thừa bên trái , phải,các từ
        // cách nhau bởi 1 khoảng trắng, ký tự đầu tiên viết hoa
        static void ToiUuChuoi()
        {
            Console.WriteLine("input your string :");
            string s = Console.ReadLine();

            s = s.Trim();

            string[] arr = s.Split(
                                    new char[] { ' ' },
                                    StringSplitOptions.RemoveEmptyEntries); // xóa theo khoảng trắng, các kí tự rỗng thì loại bỏ

            s = "";
            for(int i=0;i<arr.Length;i++)
            {
                string word = arr[i]; // lấy từng từ trong mảng ra
                word = word.ToLower();
                char[] arrword = word.ToCharArray(); // mảng các kí tự
                arrword[0] = char.ToUpper(arrword[0]);
                string newword = new string(arrword);
                s += newword + " ";
            }

            s = s.Trim();
            Console.WriteLine("Chuỗi sau khi tối ưu:");
            Console.WriteLine(s);

            Console.ReadLine();


        }
        static void Main(string[] args)
        {
            //Xulychuoi();
            // XuLyChuoi2();
            //XuLyChuoi3();
            // XuLyChuoi4();
            // XuLyChuoi5();
            //XuLyChuoi6();
            ToiUuChuoi();
        }
    }
}

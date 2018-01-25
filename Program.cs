using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocEmail
{
    class Program
    {
        static StreamReader sr;
        static StreamWriter sw;
        static string lineCheck;
        static string[] tuTrongDong;
        static string kiTuTrongDong;

        static void XuLi(string file)
        {
            sr = new StreamReader(file);
            while ((lineCheck = sr.ReadLine()) != null)
            {

                tuTrongDong = lineCheck.Split(' ');
                for (int i = 0; i < tuTrongDong.Length; i++)
                {
                    kiTuTrongDong = tuTrongDong[i];
                    for (int j = 0; j < kiTuTrongDong.Length; j++)
                    {
                        if (kiTuTrongDong[j] == '@')
                        {
                            sw.WriteLine(kiTuTrongDong);
                            break;
                        }
                    }
                }
            }
            sr.Close();
        }

        static void XuLiGmail(string file)
        {
            sr = new StreamReader(file);
            while ((lineCheck = sr.ReadLine()) != null)
            {

                tuTrongDong = lineCheck.Split(' ');
                for (int i = 0; i < tuTrongDong.Length; i++)
                {
                    kiTuTrongDong = tuTrongDong[i];
                    for (int j = 0; j < kiTuTrongDong.Length; j++)
                    {
                        if (kiTuTrongDong[j] == '@')
                        {
                            if (kiTuTrongDong.Substring(j,6)== "@gmail")
                            {
                                sw.WriteLine(kiTuTrongDong);
                                break;
                            }
                        }
                    }
                }
            }
            sr.Close();
        }

        static void XuLiYahoo(string file)
        {
            sr = new StreamReader(file);
            while ((lineCheck = sr.ReadLine()) != null)
            {

                tuTrongDong = lineCheck.Split(' ');
                for (int i = 0; i < tuTrongDong.Length; i++)
                {
                    kiTuTrongDong = tuTrongDong[i];
                    for (int j = 0; j < kiTuTrongDong.Length; j++)
                    {
                        if (kiTuTrongDong[j] == '@')
                        {
                            if (kiTuTrongDong.Substring(j,6) == "@yahoo")
                            {
                                sw.WriteLine(kiTuTrongDong);
                                break;
                            }
                        }
                    }
                }
            }
            sr.Close();
        }

        static void XuLiKhac(string file)
        {
            sr = new StreamReader(file);
            while ((lineCheck = sr.ReadLine()) != null)
            {

                tuTrongDong = lineCheck.Split(' ');
                for (int i = 0; i < tuTrongDong.Length; i++)
                {
                    kiTuTrongDong = tuTrongDong[i];
                    for (int j = 0; j < kiTuTrongDong.Length; j++)
                    {
                        if (kiTuTrongDong[j] == '@')
                        {
                            if (kiTuTrongDong.Substring(j,6) != "@gmail" && kiTuTrongDong.Substring(j,6) != "@yahoo")
                            {
                                sw.WriteLine(kiTuTrongDong);
                                break;
                            }
                        }
                    }
                }
            }
            sr.Close();
        }
        static void Main(string[] args)
        {
            string file = @"E:\Tin học\Nam I\HK 2\BT Ky thuat lap trinh\Chuong 2\LocEmail\Input.txt";
            string fileOut = @"E:\Tin học\Nam I\HK 2\BT Ky thuat lap trinh\Chuong 2\LocEmail\Output.txt";
            sw = new StreamWriter(fileOut);
            Console.WriteLine("--1-- Loc tat ca email");
            Console.WriteLine("--2-- Loc Gmail");
            Console.WriteLine("--3-- Loc Yahoo Mail");
            Console.WriteLine("--4-- Loc cac loai email khac");
            Console.Write("Nhap vao chon lua cua ban: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        XuLi(file);
                    }
                    break;
                case 2:
                    {

                        XuLiGmail(file);
                    }
                    break;
                case 3:
                    {

                        XuLiYahoo(file);
                    }
                    break;
                case 4:
                    {

                        XuLiKhac(file);
                    }
                    break;
            }
            sw.Close();
        }
    }
}

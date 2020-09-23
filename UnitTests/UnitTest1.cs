using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleUnitTest;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTask1()
        {
            //arrange
            double x = 10;
            double y = 103;
            double expected = 100.78;

            //act
            Program c = new Program();
            double actual = c.Task_1(x, y);

            //assert
            Assert.IsTrue(actual > expected, "Сумма меньше 100");
        }

        [TestMethod]
        public void TestTask2()
        {
            //arrange
            double x = 10;
            double y = 23;
            double expected = 30;

            //act
            Program c = new Program();
            double actual = c.Task_2(x, y);

            //assert
            Assert.IsTrue(actual < expected, "Сумма больше p");
        }

        [TestMethod]
        public void TestTask3()
        {
            //arrange
            int x = 21;
            int y = 23;

            //act
            Program c = new Program();
            bool actual = c.Task_3(x, y);

            //assert
            Assert.IsTrue(actual == true, "Сумма чисел не четное число");
        }

        [TestMethod]
        public void TestTask4()
        {
            //arrange
            int x = 2;
            int y = 2;
            int j = 4;
            //act
            Program c = new Program();
            bool actual = c.Task_4(x, y, j);

            //assert
            Assert.IsTrue(actual == true, "Сумма чисел {0} и {1} не кратна числу {2}", x, y, j);
        }

        [TestMethod]
        public void TestTask5()
        {
            //arrange
            double x = 3.3; //прошлый
            double y = 3.7; //текущий

            //act
            Program c = new Program();
            bool actual = c.Task_5(x, y);

            //assert
            Assert.IsTrue(actual == false, "Кол-во осадков за февраль прошлого года превысило кол-во осадков текущего", x, y);
        }

        [TestMethod]
        public void TestTask6()
        {
            //arrange
            double x = 7; //вес груза 1
            double y = 1; //вес груза 2
            double j = 10; //грузоподъемность авто

            //act
            Program c = new Program();
            bool actual = c.Task_6(x, y, j);

            //assert
            Assert.IsTrue(actual == true, "Груз превысил грузоподъемность автомобиля в {0} тонн", j);
        }

        [TestMethod]
        public void TestTask7()
        {
            //arrange
            double x = 10; //результаты первого спортсмена
            double y = 8; //результаты второго спортсмена

            //act
            Program c = new Program();
            bool actual = c.Task_7(x, y);

            //assert
            Assert.IsTrue(actual == true, "Больше баллов у второго спортсмена");
        }

        [TestMethod]
        public void TestTask8()
        {
            //arrange
            int x = 101; //цена первого товара
            int y = 61; //цена второго товара
            int j = 30; //цена третьего товара
            int z = 30; //цена мин.товара


            //act
            Program c = new Program();
            bool actual = c.Task_8(x, y, j, z);

            //assert
            Assert.IsTrue(actual == true, "Минимальный продукт не определен");
        }

        [TestMethod]
        public void TestTask9()
        {
            //arrange
            int x = 3;
            int y = 23;
            int j = 9;


            //act
            Program c = new Program();
            bool actual = c.Task_9(x, y, j);

            //assert
            Assert.IsTrue(actual == true, "Произведение чисел, равное " + (x * y * j) + " превышает 1000");
        }

        [TestMethod]
        public void TestTask10()
        {
            //arrange
            int x = 3;
            int y = 23;
            int j = 9;
            int s = 228;


            //act
            Program c = new Program();
            bool actual = c.Task_10(x, y, j, s);

            //assert
            Assert.IsTrue(actual == true, "Произведение чисел, равное " + (x * y * j) + " меньше " + s);
        }

        [TestMethod]
        public void TestTask11()
        {
            //arrange
            int x = 60;
            int y = 70;
            int j = 20;

            //act
            Program c = new Program();
            bool actual = c.Task_11(x, y, j);

            //assert
            Assert.IsTrue(actual == true, "а) Сумма чисел, что больше 20, не превышает 100 \n б) Сумма чисел, что меньше 50, нечетное число");
        }

        [TestMethod]
        public void TestTask12()
        {
            {
                //arrange
                int x = 15;
                int y = 7;
                int j = 2;

                //act
                Program c = new Program();
                bool actual = c.Task_12(x, y, j);

                //assert
                Assert.IsTrue(actual == true, "а) Сумма чисел, что меньше 20.5, не превышает 50 \n б) Сумма чисел, что не превышает 10, кратно трем");

            }
        }

        [TestMethod]
        public void TestTask13()
        {
            //arrange
            double x = 25.5;
            double y = 30;
            double p = 77;

            //act
            Program c = new Program();
            bool actual = c.Task_13(x, y, p);

            //assert
            Assert.IsTrue(actual == true, "Условия не выполнены");

        }

        [TestMethod]
        public void TestTask14()
        {
            //arrange
            int x = 1;
            int y = 3;
            int m = 7;
            int q = 9;

            //act
            Program c = new Program();
            bool actual = c.Task_14(x, y, m, q);

            //assert
            Assert.IsTrue(actual == true, "Условия не выполнены");
        }

        [TestMethod]
        public void TestTask15()
        {
            //arrange
            int x = 1;
            int y = 3;
            int m = 7;
            int p = 2;

            //act
            Program c = new Program();
            bool actual = c.Task_14(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Условия не выполнены." + (1 + 3));
        }

        [TestMethod]
        public void TestTask16()
        {
            //arrange
            int x = 1;
            int y = 2;
            int m = 1;
            int p = 2;

            //act
            Program c = new Program();
            bool actual = c.Task_16(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Условия не выполнены.");
        }

        [TestMethod]
        public void TestTask17()
        {
            //arrange
            int x = 2;
            int y = 1;
            int m = 2;
            int p = 1;

            //act
            Program c = new Program();
            bool actual = c.Task_17(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Условия не выполнены.");
        }

        [TestMethod]
        public void TestTask18()
        {
            //arrange
            int x = 2;
            int y = 1;
            int m = 2;
            int p = 1;
            int l = -5;

            //act
            Program c = new Program();
            bool actual = c.Task_18(x, y, m, p, l);

            //assert
            Assert.IsTrue(actual == true, "Условия не выполнены.");
        }

        [TestMethod]
        public void TestTask19()
        {
            //arrange
            int x = 2;
            int y = 2;
            int m = 2;
            int p = 2;

            //act
            Program c = new Program();
            bool actual = c.Task_19(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Условия не выполнены.");
        }

        [TestMethod]
        public void TestTask20()
        {
            //arrange
            int x = 2;
            int y = 2;
            int m = 2;
            int p = 2;

            //act
            Program c = new Program();
            bool actual = c.Task_20(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Условия не выполнены.");
        }


        [TestMethod]
        public void TestTask21()
        {
            //arrange
            int x = 2;
            int y = 2;
            int m = 2;
            int p = 2;
            int l = 5;

            //act
            Program c = new Program();
            bool actual = c.Task_21(x, y, m, p, l);

            //assert
            Assert.IsTrue(actual == true, "Условия не выполнены.");
        }

        [TestMethod]
        public void TestTask22()
        {
            //arrange
            int x = 2;
            int y = -2;
            int m = -1;
            int p = 1;

            //act
            Program c = new Program();
            bool actual = c.Task_22(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Условия не выполнены.");
        }

        [TestMethod]
        public void TestTask23()
        {
            //arrange
            int x = 3;
            int y = 4;
            int m = 1;
            int p = 2;

            //act
            Program c = new Program();
            bool actual = c.Task_23(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Условия не выполнены.");
        }

        [TestMethod]
        public void TestTask24()
        {
            //arrange
            int x = 4;
            int y = 5;
            int m = 4;
            int p = 5;

            //act
            Program c = new Program();
            bool actual = c.Task_24(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Условия не выполнены.");
        }

        [TestMethod]
        public void TestTask25()
        {
            //arrange
            int x = 4;
            int y = 5;
            int m = 0;
            int p = 0;

            //act
            Program c = new Program();
            bool actual = c.Task_25(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Условия не выполнены.");
        }

        [TestMethod]
        public void TestTask26()
        {
            //arrange
            int x = 5000;
            int y = 6000;
            int m = 2000;
            int p = 1000;

            //act
            Program c = new Program();
            bool actual = c.Task_26(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Условия не выполнены.");
        }

        [TestMethod]
        public void TestTask27()
        {
            //arrange
            int x = -195;
            int y = -185;
            int m = 160;
            int p = 173;

            //act
            Program c = new Program();
            bool actual = c.Task_27(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Условия не выполнены.");
        }

        [TestMethod]
        public void TestTask28()
        {
            //arrange
            int x = 4;
            int y = 2;
            int m = 3;
            int p = 1;

            //act
            Program c = new Program();
            bool actual = c.Task_28(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Нет чисел больше 10");
        }

        [TestMethod]
        public void TestTask29()
        {
            //arrange
            int x = 9;
            int y = 6;
            int m = 4;
            int p = 5;

            //act
            Program c = new Program();
            bool actual = c.Task_29(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Нет чисел больше " + p);
        }

        [TestMethod]
        public void TestTask30()
        {
            //arrange
            int x = 9;
            int y = 6;
            int m = 4;
            int p = 5;

            //act
            Program c = new Program();
            bool actual = c.Task_30(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Нет чисел больше " + p);
        }

        [TestMethod]
        public void TestTask31()
        {
            //arrange
            int x = 20;
            int y = 25;
            int m = 8;
            int p = 5;

            //act
            Program c = new Program();
            bool actual = c.Task_31(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Нет чисел кратных " + p);
        }

        [TestMethod]
        public void TestTask32()
        {
            //arrange
            int x = 100;
            int y = 25;
            int m = 8;
            int p = 100;

            //act
            Program c = new Program();
            bool actual = c.Task_32(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Нет чисел равных " + p);
        }

        [TestMethod]
        public void TestTask33()
        {
            //arrange
            int x = 3;
            int y = 5;
            int m = 8;
            int p = 69;

            //act
            Program c = new Program();
            bool actual = c.Task_33(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Отрицательные числа не найдены");
        }

        [TestMethod]
        public void TestTask34()
        {
            //arrange
            int x = 3;
            int y = 5;
            int m = 8;
            int p = 20;

            //act
            Program c = new Program();
            bool actual = c.Task_34(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Максимальное число превышет минимальное более чем на 25");
        }

        [TestMethod]
        public void TestTask35()
        {
            //arrange
            int x = 3;
            int y = 5;
            int m = 8;
            int p = 20;

            //act
            Program c = new Program();
            bool actual = c.Task_35(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Максимальное число не превышает минимальное в 2 раза");
        }

        [TestMethod]
        public void TestTask36()
        {
            //arrange
            int x = 60;
            int y = 5;
            int m = 8;
            int p = 20;

            //act
            Program c = new Program();
            bool actual = c.Task_36(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Минимальный индекс встречается первым");
        }

        [TestMethod]
        public void TestTask37()
        {
            //arrange
            int x = 20;
            int y = 22;
            int m = 38;
            int p = 70;

            //act
            Program c = new Program();
            bool actual = c.Task_37(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Первым встречается молодой");
        }

        [TestMethod]
        public void TestTask38()
        {
            //arrange
            double x = 2.05;
            double y = 2.15;
            double m = 3.1;
            double p = 2.10;

            //act
            Program c = new Program();
            bool actual = c.Task_38(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Первым встречается молодой");
        }

        [TestMethod]
        public void TestTask39()
        {
            //arrange
            int x = 9;
            int y = 9;
            int m = 2;
            int p = 3;

            //act
            Program c = new Program();
            bool actual = c.Task_39(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Повторяющихся и неповторяющихся последовательностей нет");
        }

        [TestMethod]
        public void TestTask40()
        {
            //arrange
            int x = 1;
            int y = 3;
            int m = 3;
            int p = 7;

            //act
            Program c = new Program();
            bool actual = c.Task_40(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Неповторяющихся чисел нет");
        }

        [TestMethod]
        public void TestTask41()
        {
            //arrange
            int x = 2;
            int y = 0;
            int m = 4;
            int p = 5;

            //act
            Program c = new Program();
            bool actual = c.Task_41(x, y, m, p);

            //assert
            Assert.IsTrue(actual == true, "Условия не соблюдены");
        }

        [TestMethod]
        public void TestTask42()
        {
            //arrange
            int N = 7;

            //act
            Program c = new Program();
            bool actual = c.Task_42(N);

            //assert
            Assert.IsTrue(actual == true, "Число не простое");
        }

        [TestMethod]
        public void TestTask43()
        {
            //arrange
            int value = 6;

            //act
            Program c = new Program();
            bool actual = c.Task_43(value);

            //assert
            Assert.IsTrue(actual == true, "Число не совершенное");
        }
    }
}
